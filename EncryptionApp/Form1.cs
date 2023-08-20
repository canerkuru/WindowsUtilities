namespace EncryptionApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnEncrypt_Click(object sender, EventArgs e)
    {
        var secset = new SecuritySettings();

        try
        {
            var enc = new EncryptionService(secset);
            secset.EncryptionKey = txtKey.Text;
            string sss = enc.EncryptText(txtInput.Text);
            txtOutput.Text = sss;
        }
        catch (Exception ex)
        {
            txtOutput.Text = ex.ToString();
        }
    }

    private void btnDecrypt_Click(object sender, EventArgs e)
    {
        var secset = new SecuritySettings();

        try
        {
            var enc = new EncryptionService(secset);
            secset.EncryptionKey = txtKey.Text;
            string sss = enc.DecryptText(txtInput.Text);
            txtOutput.Text = sss;
        }
        catch (Exception ex)
        {
            txtOutput.Text = ex.ToString();
        }
    }
}
