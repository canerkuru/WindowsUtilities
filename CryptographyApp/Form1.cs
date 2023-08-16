using System.Text;

namespace CryptographyApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnEncrypt_Click(object sender, EventArgs e)
    {
        try
        {
            AESService.key = Encoding.UTF8.GetBytes(txtKey.Text);
            AESService.iv = Encoding.UTF8.GetBytes(txtIV.Text);
            txtOutput.Text = AESService.Encrypt(txtInput.Text);


        }
        catch (Exception ex)
        {
            txtOutput.Text = ex.Message;
        }

    }

    private void btnDecrypt_Click(object sender, EventArgs e)
    {
        try
        {
            AESService.key = Encoding.UTF8.GetBytes(txtKey.Text);
            AESService.iv = Encoding.UTF8.GetBytes(txtIV.Text);
            txtOutput.Text = AESService.Decrypt(txtInput.Text);
        }
        catch (Exception ex)
        {
            txtOutput.Text = ex.Message;
        }
    }
}
