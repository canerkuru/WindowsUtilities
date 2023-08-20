namespace EncryptionApp;

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
        txtOutput = new TextBox();
        txtInput = new TextBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        txtKey = new TextBox();
        btnDecrypt = new Button();
        SuspendLayout();
        // 
        // btnEncrypt
        // 
        btnEncrypt.Location = new Point(774, 504);
        btnEncrypt.Name = "btnEncrypt";
        btnEncrypt.Size = new Size(112, 34);
        btnEncrypt.TabIndex = 0;
        btnEncrypt.Text = "Encrypt";
        btnEncrypt.UseVisualStyleBackColor = true;
        btnEncrypt.Click += btnEncrypt_Click;
        // 
        // txtOutput
        // 
        txtOutput.Location = new Point(108, 196);
        txtOutput.Multiline = true;
        txtOutput.Name = "txtOutput";
        txtOutput.Size = new Size(896, 302);
        txtOutput.TabIndex = 1;
        // 
        // txtInput
        // 
        txtInput.Location = new Point(108, 82);
        txtInput.Multiline = true;
        txtInput.Name = "txtInput";
        txtInput.Size = new Size(896, 108);
        txtInput.TabIndex = 2;
        txtInput.Text = "caner";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(39, 82);
        label1.Name = "label1";
        label1.Size = new Size(63, 30);
        label1.TabIndex = 3;
        label1.Text = "Input";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(21, 196);
        label2.Name = "label2";
        label2.Size = new Size(81, 30);
        label2.TabIndex = 4;
        label2.Text = "Output";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(53, 27);
        label3.Name = "label3";
        label3.Size = new Size(49, 30);
        label3.TabIndex = 5;
        label3.Text = "Key";
        // 
        // txtKey
        // 
        txtKey.Location = new Point(108, 28);
        txtKey.Name = "txtKey";
        txtKey.Size = new Size(896, 31);
        txtKey.TabIndex = 6;
        txtKey.Text = "5976577829964441";
        // 
        // btnDecrypt
        // 
        btnDecrypt.Location = new Point(892, 504);
        btnDecrypt.Name = "btnDecrypt";
        btnDecrypt.Size = new Size(112, 34);
        btnDecrypt.TabIndex = 7;
        btnDecrypt.Text = "Decrypt";
        btnDecrypt.UseVisualStyleBackColor = true;
        btnDecrypt.Click += btnDecrypt_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1041, 559);
        Controls.Add(btnDecrypt);
        Controls.Add(txtKey);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtInput);
        Controls.Add(txtOutput);
        Controls.Add(btnEncrypt);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnEncrypt;
    private TextBox txtOutput;
    private TextBox txtInput;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox txtKey;
    private Button btnDecrypt;
}
