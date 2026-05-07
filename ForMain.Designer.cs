    namespace CalculadoraDeMedias07
    {
        partial class FormMain
        {
            private System.ComponentModel.IContainer components = null;
            protected override void Dispose(bool disposing)
            {
                if (disposing && components != null) components.Dispose();
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code
            private void InitializeComponent()
            {
                pnlStatus = new Panel();
                lblStatusTitulo = new Label();
                lblStatus = new Label();
                pnlSemestral = new Panel();
                lblSecSem = new Label();
                lblNP1 = new Label();
                lblNP2 = new Label();
                lblPIM = new Label();
                lblSemLabel = new Label();
                txtNP1 = new TextBox();
                txtNP2 = new TextBox();
                txtPIM = new TextBox();
                lblSemestral = new Label();
                btnLimparSem = new Button();
                btnSemestral = new Button();
                pnlFinal = new Panel();
                lblSecFinal = new Label();
                lblExame = new Label();
                lblFinalLabel = new Label();
                txtExame = new TextBox();
                lblFinal = new Label();
                btnLimparFinal = new Button();
                btnFinal = new Button();

                SuspendLayout();

                var corAzulEscuro = Color.FromArgb(31, 56, 100);
                var corAzulMedio = Color.FromArgb(24, 95, 165);
                var corAzulClaro = Color.FromArgb(235, 243, 251);
                var corResultado = Color.FromArgb(220, 235, 250);
                var corFundo = Color.FromArgb(245, 246, 248);
                var corPainel = Color.FromArgb(238, 240, 244);
                var corTextoSec = Color.FromArgb(100, 110, 130);
                var corTextoRes = Color.FromArgb(12, 68, 124);

                var fonte = new Font("Segoe UI", 10f);
                var fonteBold = new Font("Segoe UI", 10f, FontStyle.Bold);
                var fonteTiny = new Font("Segoe UI", 8f, FontStyle.Bold);
                var fonteGrande = new Font("Segoe UI", 15f, FontStyle.Bold);

                // Form
                Text = "Cálculo de Médias e Status  |  ESWA+POO";
                ClientSize = new Size(460, 600);
                MinimumSize = new Size(476, 639);
                StartPosition = FormStartPosition.CenterScreen;
                BackColor = corFundo;
                Font = fonte;
                FormBorderStyle = FormBorderStyle.FixedSingle;
                MaximizeBox = false;
                AutoScaleMode = AutoScaleMode.Dpi;

                // STATUS
                pnlStatus.Location = new Point(16, 16);
                pnlStatus.Size = new Size(428, 76);
                pnlStatus.BackColor = corAzulClaro;

                lblStatusTitulo.Text = "STATUS";
                lblStatusTitulo.Font = fonteTiny;
                lblStatusTitulo.ForeColor = corAzulMedio;
                lblStatusTitulo.Dock = DockStyle.Top;
                lblStatusTitulo.Height = 24;
                lblStatusTitulo.TextAlign = ContentAlignment.BottomCenter;

                lblStatus.Text = "Em Andamento";
                lblStatus.Font = fonteGrande;
                lblStatus.ForeColor = corAzulEscuro;
                lblStatus.Dock = DockStyle.Fill;
                lblStatus.TextAlign = ContentAlignment.MiddleCenter;

                pnlStatus.Controls.Add(lblStatus);
                pnlStatus.Controls.Add(lblStatusTitulo);

                // SEMESTRAL
                pnlSemestral.Location = new Point(16, 108);
                pnlSemestral.Size = new Size(428, 216);
                pnlSemestral.BackColor = corPainel;

                lblSecSem.Text = "SEMESTRAL";
                lblSecSem.Font = fonteTiny;
                lblSecSem.ForeColor = corAzulMedio;
                lblSecSem.Location = new Point(14, 10);
                lblSecSem.Size = new Size(400, 18);

                int y = 36;
                CriarCampo(pnlSemestral, lblNP1, "NP1", txtNP1, ref y, fonte, corTextoSec);
                CriarCampo(pnlSemestral, lblNP2, "NP2", txtNP2, ref y, fonte, corTextoSec);
                CriarCampo(pnlSemestral, lblPIM, "PIM", txtPIM, ref y, fonte, corTextoSec);

                lblSemLabel.Text = "Semestral";
                lblSemLabel.Font = fonteBold;
                lblSemLabel.ForeColor = Color.FromArgb(44, 44, 44);
                lblSemLabel.Location = new Point(14, y);
                lblSemLabel.Size = new Size(100, 30);
                lblSemLabel.TextAlign = ContentAlignment.MiddleLeft;

                lblSemestral.Text = "0,0";
                lblSemestral.Font = fonteBold;
                lblSemestral.ForeColor = corTextoRes;
                lblSemestral.BackColor = corResultado;
                lblSemestral.Location = new Point(120, y);
                lblSemestral.Size = new Size(294, 30);
                lblSemestral.TextAlign = ContentAlignment.MiddleRight;
                lblSemestral.Padding = new Padding(0, 0, 8, 0);

                y += 38;
                // botões alinhados à direita com larguras generosas
                btnSemestral.Text = "Semestral";
                btnSemestral.Size = new Size(130, 32);
                btnSemestral.Location = new Point(284, y);
                BotaoPrimario(btnSemestral, fonteBold, corAzulEscuro, corAzulMedio);
                btnSemestral.Click += btnSemestral_Click;

                btnLimparSem.Text = "Limpar";
                btnLimparSem.Size = new Size(90, 32);
                btnLimparSem.Location = new Point(186, y);
                BotaoSecundario(btnLimparSem, fonte, corTextoSec);
                btnLimparSem.Click += btnLimparSemestral_Click;

                pnlSemestral.Controls.AddRange(new Control[] {
                    lblSecSem,
                    lblNP1, txtNP1, lblNP2, txtNP2, lblPIM, txtPIM,
                    lblSemLabel, lblSemestral,
                    btnLimparSem, btnSemestral
                });

                // FINAL
                pnlFinal.Location = new Point(16, 340);
                pnlFinal.Size = new Size(428, 156);
                pnlFinal.BackColor = corPainel;

                lblSecFinal.Text = "FINAL";
                lblSecFinal.Font = fonteTiny;
                lblSecFinal.ForeColor = corAzulMedio;
                lblSecFinal.Location = new Point(14, 10);
                lblSecFinal.Size = new Size(400, 18);

                y = 36;
                CriarCampo(pnlFinal, lblExame, "Exame", txtExame, ref y, fonte, corTextoSec);
                txtExame.Enabled = false;

                lblFinalLabel.Text = "Final";
                lblFinalLabel.Font = fonteBold;
                lblFinalLabel.ForeColor = Color.FromArgb(44, 44, 44);
                lblFinalLabel.Location = new Point(14, y);
                lblFinalLabel.Size = new Size(100, 30);
                lblFinalLabel.TextAlign = ContentAlignment.MiddleLeft;

                lblFinal.Text = "0,0";
                lblFinal.Font = fonteBold;
                lblFinal.ForeColor = corTextoRes;
                lblFinal.BackColor = corResultado;
                lblFinal.Location = new Point(120, y);
                lblFinal.Size = new Size(294, 30);
                lblFinal.TextAlign = ContentAlignment.MiddleRight;
                lblFinal.Padding = new Padding(0, 0, 8, 0);

                y += 38;
                btnFinal.Text = "Final";
                btnFinal.Size = new Size(130, 32);
                btnFinal.Location = new Point(284, y);
                BotaoPrimario(btnFinal, fonteBold, corAzulEscuro, corAzulMedio);
                btnFinal.Enabled = false;
                btnFinal.Click += btnFinal_Click;

                btnLimparFinal.Text = "Limpar";
                btnLimparFinal.Size = new Size(90, 32);
                btnLimparFinal.Location = new Point(186, y);
                BotaoSecundario(btnLimparFinal, fonte, corTextoSec);
                btnLimparFinal.Enabled = false;
                btnLimparFinal.Click += btnLimparFinal_Click;

                pnlFinal.Controls.AddRange(new Control[] {
                    lblSecFinal,
                    lblExame, txtExame,
                    lblFinalLabel, lblFinal,
                    btnLimparFinal, btnFinal
                });

                Controls.AddRange(new Control[] { pnlStatus, pnlSemestral, pnlFinal });
                ResumeLayout(false);
            }

            private static void CriarCampo(Panel pai, Label lbl, string nome,
                TextBox txt, ref int y, Font fonte, Color corLabel)
            {
                lbl.Text = nome;
                lbl.Font = fonte;
                lbl.ForeColor = corLabel;
                lbl.Location = new Point(14, y);
                lbl.Size = new Size(100, 30);
                lbl.TextAlign = ContentAlignment.MiddleLeft;

                txt.Location = new Point(120, y);
                txt.Size = new Size(294, 28);
                txt.TextAlign = HorizontalAlignment.Right;
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.Font = fonte;
                txt.TextChanged += (s, _) =>
                {
                    if (s is not TextBox tb) return;
                    int pos = tb.SelectionStart;
                    string san = System.Text.RegularExpressions.Regex.Replace(tb.Text, @"[^0-9,]", "");
                    if (tb.Text != san) { tb.Text = san; tb.SelectionStart = Math.Max(0, pos - 1); }
                };
                y += 36;
            }

            private static void BotaoPrimario(Button b, Font f, Color bg, Color hover)
            {
                b.Font = f;
                b.BackColor = bg;
                b.ForeColor = Color.White;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.FlatAppearance.MouseOverBackColor = hover;
                b.Cursor = Cursors.Hand;
            }

            private static void BotaoSecundario(Button b, Font f, Color fg)
            {
                b.Font = f;
                b.BackColor = Color.Transparent;
                b.ForeColor = fg;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderColor = Color.FromArgb(180, 190, 205);
                b.FlatAppearance.BorderSize = 1;
                b.Cursor = Cursors.Hand;
            }

            #endregion

            private Panel pnlStatus, pnlSemestral, pnlFinal;
            private Label lblStatusTitulo, lblStatus;
            private Label lblSecSem, lblNP1, lblNP2, lblPIM, lblSemLabel, lblSemestral;
            private Label lblSecFinal, lblExame, lblFinalLabel, lblFinal;
            private TextBox txtNP1, txtNP2, txtPIM, txtExame;
            private Button btnLimparSem, btnSemestral, btnLimparFinal, btnFinal;
        }
    }
