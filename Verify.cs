using System;
using SKM.V3;
using SKM.V3.Methods;
using SKM.V3.Models;
namespace Print_SCP
{
    class Verify
    {
        public string Key_verification(string key)
        {
            string days=null;
            var licenseKey = key;
            var RSAPubKey = "<RSAKeyValue><Modulus>tbXLh1SWGzX2davgkaEnHw4n5vlSdCdlxVcfNNHYMGZsBzWMsqiAFoaQZFk+yEFq9Uai+QHZhITIC5g2/MYZgDjjNgMFDkEoE804vn7gv3WNOI9yRSI3THRhNJtHpjA5W4TDCUlf9rRm5TguWJTl4vkYNMO+Axru6qaa/KAZ/jj+VC5lSU+w//yf7OveCXy/iYYyS4U1zrxBELrGBRR3421HYaJ8FKMY2KKFj42yGNhz9KqGo8J6I/mQQmwILhsENgOuz0mZtdf03plcIbqdxBtwbJkUtEDG7m4Z/Re8EC4rn8Zd9H/Kd5v94K1TOzGTyO916J9vaHmq+KCQQAaYQQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

            var auth = "WyI4NDgwIiwia3NYZ21nZUdHSmdTUEc3ODVaaXE2ckRzQyttTkpXSm1rVXE3TE5jUiJd";

            var result = Key.Activate(token: auth, parameters: new ActivateModel()
            {
                Key = licenseKey,
                ProductId = 4984,
                Sign = true,
                MachineCode = Helpers.GetMachineCode()
            });

            if (result == null || result.Result == ResultType.Error ||
                !result.LicenseKey.HasValidSignature(RSAPubKey).IsValid())
            {
                // an error occurred or the key is invalid or it cannot be activated
                // (eg. the limit of activated devices was achieved)
                Properties.Settings.Default.days = 0;
                return "-1";
              
            }
            else
            {
                // everything went fine if we are here!
                if (result.LicenseKey.DaysLeft().ToString() == "0")
                {
                    Properties.Settings.Default.days = 0;
                    return "0";
                }
                   
                else
                {
                    days = result.LicenseKey.DaysLeft().ToString();
                    Properties.Settings.Default.days = Convert.ToInt32(days);
                    return days;
                }
                   
               
            }

         

        }
    }
}
