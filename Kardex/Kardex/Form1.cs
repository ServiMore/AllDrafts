using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Kardex {
    public partial class Form1 : Form {

        private decimal existenciaActual = 0;
        private decimal costoPromedio = 0;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            initial.Checked = true;
            income.Enabled = false;
            outcome.Enabled = false;
        }

        private void save_Click(object sender, EventArgs e) {
            agregar();
            limpiar();

        }

        private void agregar() {
            kardexList.Rows.Add(
                datePicker.Value,
                description.Text,
                income.Checked ? quantity.Value : 0,
                outcome.Checked ? quantity.Value : 0,
                CalcularExistencia(),
                CalcularCostoUnitario(),
                CalcularCostoPromedio(),
                CalcularDebe(),
                CalcularHaber(),
                costoPromedio * existenciaActual
                );
        }

        private decimal CalcularDebe() {
            if (outcome.Checked)
                return 0;
            return quantity.Value * cost.Value;
        }

        private decimal CalcularHaber() {
            if (!outcome.Checked)
                return 0;
            return quantity.Value * costoPromedio;
        }

        private decimal CalcularExistencia() {
            if (initial.Checked) {
                existenciaActual = quantity.Value;
            } else if (income.Checked) {
                existenciaActual += quantity.Value;
            } else {
                existenciaActual -= quantity.Value;
            }

            return existenciaActual;
        }

        private decimal CalcularCostoPromedio() {
            if (initial.Checked) {
                costoPromedio = cost.Value;
            } else if (income.Checked) {
                var total = (existenciaActual - quantity.Value) * costoPromedio + quantity.Value * cost.Value;
                costoPromedio = total / existenciaActual;
            }

            return costoPromedio;
        }

        private decimal CalcularCostoUnitario() {
            if (initial.Checked || income.Checked) {
                return cost.Value;
            }
            return costoPromedio;
        }

        private void limpiar() {
            datePicker.Value = DateTime.Today;
            description.Text = string.Empty;
            income.Checked = true;
            quantity.Value = 0;
            cost.Value = 0;

            initial.Enabled = false;
            income.Enabled = true;
            outcome.Enabled = true;
        }

        private void income_CheckedChanged(object sender, EventArgs e) {
        }

        private void outcome_CheckedChanged(object sender, EventArgs e) {
            cost.Enabled = !outcome.Checked;
            if (!cost.Enabled)
                cost.Value = 0;
        }

        private void serialize_Click(object sender, EventArgs e) {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                var lines = new List<string>();
                foreach (DataGridViewRow row in kardexList.Rows) {
                    var line = string.Empty;
                    foreach (DataGridViewCell cell in row.Cells) {
                        line += cell.Value + ",";
                    }
                    lines.Add(line);
                }
                File.WriteAllLines(saveFileDialog1.FileName, lines);
            }
        }

        private void deserialize_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                var lines = File.ReadAllLines(openFileDialog1.FileName);
                foreach (string line in lines) {
                    var values = line.Split(',');
                    kardexList.Rows.Add(values);
                }

                var lastLine = lines[lines.Length - 1];
                var lastValues = lastLine.Split(',');
                existenciaActual = Convert.ToDecimal(lastValues[4]);
                costoPromedio = Convert.ToDecimal(lastValues[6]);

                limpiar();
            }
        }
    }
}
