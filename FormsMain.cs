using ESWA07CalculadoraDeMedias;
using OOPFoundation;

namespace CalculadoraDeMedias07
{
    /// <summary>
    /// Formulário principal do Aplicativo Calculadora de Médias.
    /// Parte 1: campos, inicialização e reset.
    /// </summary>
    public partial class FormMain : Form
    {
        private readonly GradeCalculator _calculator;
        private readonly OOPFoundation.Text _textSanitizer;

        private double _semestralAverage = 0.0;

        public FormMain()
        {
            InitializeComponent();
            _calculator    = new GradeCalculator();
            _textSanitizer = new OOPFoundation.Text();
            ResetAll();
        }

        // ── Reset completo (Limpar Semestral) ─────────────────────────────────
        private void ResetAll()
        {
            txtNP1.Text  = string.Empty;
            txtNP2.Text  = string.Empty;
            txtPIM.Text  = string.Empty;
            txtExame.Text = string.Empty;

            lblSemestral.Text = "0,0";
            lblFinal.Text     = "0,0";

            lblStatus.Text      = "Em Andamento";
            lblStatus.ForeColor = Color.Black;

            _semestralAverage = 0.0;
            SetFinalSectionEnabled(false);
        }

        // ── Habilitar / desabilitar seção Final ───────────────────────────────
        private void SetFinalSectionEnabled(bool enabled)
        {
            txtExame.Enabled       = enabled;
            lblFinal.Enabled       = enabled;
            btnLimparFinal.Enabled = enabled;
            btnFinal.Enabled       = enabled;
        }

        // ── Validação e parse de nota ─────────────────────────────────────────
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
    }
}
