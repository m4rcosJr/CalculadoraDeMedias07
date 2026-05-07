using ESWA07CalculadoraDeMedias;
using OOPFoundation;

namespace CalculadoraDeMedias07
{
    /// <summary>
    /// Formulário principal do Aplicativo Calculadora de Médias.
    /// </summary>
    public partial class FormMain : Form
    {
        private readonly GradeCalculator _calculator;
        private readonly Text _textSanitizer;

        private double _semestralAverage = 0.0;

        public FormMain()
        {
            InitializeComponent();
            _calculator = new GradeCalculator();
            _textSanitizer = new Text();
            ResetAll();
        }

        // ─── Botão Semestral ──────────────────────────────────────────────────
        private void btnSemestral_Click(object sender, EventArgs e)
        {
            if (!TryParseNote(txtNP1.Text, "NP1", out double np1)) return;
            if (!TryParseNote(txtNP2.Text, "NP2", out double np2)) return;
            if (!TryParseNote(txtPIM.Text, "PIM", out double pim)) return;

            _semestralAverage = _calculator.CalculateSemestralAverage(np1, np2, pim);
            lblSemestral.Text = _semestralAverage.ToString("F1");

            var status = _calculator.GetSemestralStatus(_semestralAverage);
            ApplySemestralStatus(status);
        }

        // ─── Botão Final ──────────────────────────────────────────────────────
        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (!TryParseNote(txtExame.Text, "Exame", out double exam)) return;

            double finalAverage = _calculator.CalculateFinalAverage(_semestralAverage, exam);
            lblFinal.Text = finalAverage.ToString("F1");

            var status = _calculator.GetFinalStatus(finalAverage);
            ApplyFinalStatus(status);
        }

        // ─── Botão Limpar (Semestral) ─────────────────────────────────────────
        private void btnLimparSemestral_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        // ─── Botão Limpar (Final) ─────────────────────────────────────────────
        private void btnLimparFinal_Click(object sender, EventArgs e)
        {
            txtExame.Text = string.Empty;
            lblFinal.Text = "0,0";
            lblStatus.ForeColor = Color.Black;
        }
        // ─── Sanitização de entrada ───────────────────────────────────────────
        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                int pos = tb.SelectionStart;
                string sanitized = _textSanitizer.Sanitize(tb.Text);
                if (tb.Text != sanitized)
                {
                    tb.Text = sanitized;
                    tb.SelectionStart = Math.Max(0, pos - 1);
                }
            }
        }
 
        // ─── Helpers ─────────────────────────────────────────────────────────
        private bool TryParseNote(string input, string fieldName, out double value)
        {
            value = 0.0;
            string sanitized = _textSanitizer.Sanitize(input).Replace(',', '.');
 
            if (!double.TryParse(sanitized,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out value))
            {
                MessageBox.Show($"O campo '{fieldName}' contém um valor inválido.",
                    "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
 
            if (!_calculator.IsNoteValid(value))
            {
                MessageBox.Show($"O campo '{fieldName}' deve estar entre 0,0 e 10,0.",
                    "Valor Fora do Intervalo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
 
            return true;
        }
 
        private void ApplySemestralStatus(StudentStatus status)
        {
            switch (status)
            {
                case StudentStatus.Aprovado:
                    lblStatus.Text = "Aprovado";
                    lblStatus.ForeColor = Color.Green;
                    SetFinalSectionEnabled(false);
                    break;
 
                case StudentStatus.EmExame:
                    lblStatus.Text = "Em Exame";
                    lblStatus.ForeColor = Color.Orange;
                    SetFinalSectionEnabled(true);
                    break;
            }
        }
 
        private void ApplyFinalStatus(StudentStatus status)
        {
            switch (status)
            {
                case StudentStatus.Aprovado:
                    lblStatus.Text = "Aprovado";
                    lblStatus.ForeColor = Color.Green;
                    break;
 
                case StudentStatus.Reprovado:
                    lblStatus.Text = "Reprovado";
                    lblStatus.ForeColor = Color.Red;
                    break;
            }
        }
 
        private void SetFinalSectionEnabled(bool enabled)
        {
            txtExame.Enabled = enabled;
            lblFinal.Enabled = enabled;
            btnLimparFinal.Enabled = enabled;
            btnFinal.Enabled = enabled;
        }
 
        private void ResetAll()
        {
            txtNP1.Text = string.Empty;
            txtNP2.Text = string.Empty;
            txtPIM.Text = string.Empty;
            txtExame.Text = string.Empty;
 
            lblSemestral.Text = "0,0";
            lblFinal.Text = "0,0";
 
            lblStatus.Text = "Em Andamento";
            lblStatus.ForeColor = Color.Black;
 
            _semestralAverage = 0.0;
            SetFinalSectionEnabled(false);
        }
    }
}
