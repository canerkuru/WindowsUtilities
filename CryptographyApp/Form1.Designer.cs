namespace CryptographyApp;

partial class Form1
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
        btnEncrypt = new Button();
        txtKey = new TextBox();
        txtIV = new TextBox();
        label1 = new Label();
        label2 = new Label();
        btnDecrypt = new Button();
        txtInput = new TextBox();
        txtOutput = new TextBox();
        label3 = new Label();
        label4 = new Label();
        textBox1 = new TextBox();
        SuspendLayout();
        // 
        // btnEncrypt
        // 
        btnEncrypt.Location = new Point(688, 406);
        btnEncrypt.Name = "btnEncrypt";
        btnEncrypt.Size = new Size(112, 34);
        btnEncrypt.TabIndex = 0;
        btnEncrypt.Text = "Encrypt";
        btnEncrypt.UseVisualStyleBackColor = true;
        btnEncrypt.Click += btnEncrypt_Click;
        // 
        // txtKey
        // 
        txtKey.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtKey.Location = new Point(137, 34);
        txtKey.Name = "txtKey";
        txtKey.Size = new Size(482, 37);
        txtKey.TabIndex = 1;
        txtKey.Text = "0000000000000001";
        // 
        // txtIV
        // 
        txtIV.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtIV.Location = new Point(137, 94);
        txtIV.Name = "txtIV";
        txtIV.Size = new Size(482, 37);
        txtIV.TabIndex = 2;
        txtIV.Text = "0000000000000002";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(82, 35);
        label1.Name = "label1";
        label1.Size = new Size(49, 30);
        label1.TabIndex = 3;
        label1.Text = "Key";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(89, 94);
        label2.Name = "label2";
        label2.Size = new Size(33, 30);
        label2.TabIndex = 4;
        label2.Text = "IV";
        // 
        // btnDecrypt
        // 
        btnDecrypt.Location = new Point(836, 406);
        btnDecrypt.Name = "btnDecrypt";
        btnDecrypt.Size = new Size(112, 34);
        btnDecrypt.TabIndex = 5;
        btnDecrypt.Text = "Decrypt";
        btnDecrypt.UseVisualStyleBackColor = true;
        btnDecrypt.Click += btnDecrypt_Click;
        // 
        // txtInput
        // 
        txtInput.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtInput.Location = new Point(137, 153);
        txtInput.Multiline = true;
        txtInput.Name = "txtInput";
        txtInput.Size = new Size(811, 108);
        txtInput.TabIndex = 6;
        // 
        // txtOutput
        // 
        txtOutput.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtOutput.Location = new Point(137, 273);
        txtOutput.Multiline = true;
        txtOutput.Name = "txtOutput";
        txtOutput.Size = new Size(811, 108);
        txtOutput.TabIndex = 7;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(64, 156);
        label3.Name = "label3";
        label3.Size = new Size(63, 30);
        label3.TabIndex = 8;
        label3.Text = "Input";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(47, 276);
        label4.Name = "label4";
        label4.Size = new Size(81, 30);
        label4.TabIndex = 9;
        label4.Text = "Output";
        // 
        // textBox1
        // 
        textBox1.BackColor = SystemColors.Control;
        textBox1.Location = new Point(137, 387);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(316, 31);
        textBox1.TabIndex = 10;
        textBox1.Text = "Developed by github.com/canerkuru";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(981, 469);
        Controls.Add(textBox1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(txtOutput);
        Controls.Add(txtInput);
        Controls.Add(btnDecrypt);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtIV);
        Controls.Add(txtKey);
        Controls.Add(btnEncrypt);
        Name = "Form1";
        Text = "Advanced Encryption Standard (AES)";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnEncrypt;
    private TextBox txtKey;
    private TextBox txtIV;
    private Label label1;
    private Label label2;
    private Button btnDecrypt;
    private TextBox txtInput;
    private TextBox txtOutput;
    private Label label3;
    private Label label4;
    private TextBox textBox1;
}
