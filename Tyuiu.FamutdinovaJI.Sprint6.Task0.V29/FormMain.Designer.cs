
namespace Tyuiu.FamutdinovaJI.Sprint6.Task0.V29
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxProblem = new TextBox();
            groupBoxProblem = new GroupBox();
            groupBoxInput = new GroupBox();
            textBoxVarInput = new TextBox();
            textBoxVar = new TextBox();
            groupBoxResult = new GroupBox();
            textBoxResultOutput = new TextBox();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            pictureBoxForm = new PictureBox();
            groupBoxProblem.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForm).BeginInit();
            SuspendLayout();
            // 
            // textBoxProblem
            // 
            textBoxProblem.BorderStyle = BorderStyle.None;
            textBoxProblem.Location = new Point(21, 65);
            textBoxProblem.Name = "textBoxProblem";
            textBoxProblem.ReadOnly = true;
            textBoxProblem.Size = new Size(212, 16);
            textBoxProblem.TabIndex = 0;
            textBoxProblem.Text = "Вычислить выражение по формуле:";
            // 
            // groupBoxProblem
            // 
            groupBoxProblem.Controls.Add(pictureBoxForm);
            groupBoxProblem.Controls.Add(textBoxProblem);
            groupBoxProblem.Location = new Point(41, 35);
            groupBoxProblem.Name = "groupBoxProblem";
            groupBoxProblem.Size = new Size(443, 160);
            groupBoxProblem.TabIndex = 1;
            groupBoxProblem.TabStop = false;
            groupBoxProblem.Text = "Условие:";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxVarInput);
            groupBoxInput.Controls.Add(textBoxVar);
            groupBoxInput.Location = new Point(44, 212);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(340, 148);
            groupBoxInput.TabIndex = 2;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxVarInput
            // 
            textBoxVarInput.Location = new Point(31, 74);
            textBoxVarInput.Name = "textBoxVarInput";
            textBoxVarInput.Size = new Size(126, 23);
            textBoxVarInput.TabIndex = 1;
            textBoxVarInput.TextChanged += buttonDone_Click;
            textBoxVarInput.KeyPress += textBoxVarInput_KeyPress;
            // 
            // textBoxVar
            // 
            textBoxVar.BorderStyle = BorderStyle.None;
            textBoxVar.Location = new Point(31, 45);
            textBoxVar.Name = "textBoxVar";
            textBoxVar.Size = new Size(78, 16);
            textBoxVar.TabIndex = 0;
            textBoxVar.Text = "Переменная Х:";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResultOutput);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(432, 212);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(222, 148);
            groupBoxResult.TabIndex = 3;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            groupBoxResult.Enter += groupBoxResult_Enter;
            // 
            // textBoxResultOutput
            // 
            textBoxResultOutput.Location = new Point(28, 79);
            textBoxResultOutput.Name = "textBoxResultOutput";
            textBoxResultOutput.ReadOnly = true;
            textBoxResultOutput.Size = new Size(143, 23);
            textBoxResultOutput.TabIndex = 1;
            textBoxResultOutput.TextChanged += textBoxResultOutput_TextChanged;
            // 
            // textBoxResult
            // 
            textBoxResult.BorderStyle = BorderStyle.None;
            textBoxResult.Location = new Point(28, 50);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(78, 16);
            textBoxResult.TabIndex = 0;
            textBoxResult.Text = "Результат";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(532, 380);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(144, 41);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // pictureBoxForm
            // 
            pictureBoxForm.Cursor = Cursors.No;
            pictureBoxForm.Image = (Image)resources.GetObject("pictureBoxForm.Image");
            pictureBoxForm.Location = new Point(267, 52);
            pictureBoxForm.Name = "pictureBoxForm";
            pictureBoxForm.Size = new Size(95, 52);
            pictureBoxForm.TabIndex = 5;
            pictureBoxForm.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 450);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxProblem);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxProblem.ResumeLayout(false);
            groupBoxProblem.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForm).EndInit();
            ResumeLayout(false);
        }

        private void textBoxForm_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBoxProblem;
        private GroupBox groupBoxProblem;
        private GroupBox groupBoxInput;
        private TextBox textBoxVarInput;
        private TextBox textBoxVar;
        private GroupBox groupBoxResult;
        private TextBox textBoxResultOutput;
        private TextBox textBoxResult;
        private Button buttonDone;
        private PictureBox pictureBoxForm;
    }
}
