using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_SCP
{
    class FormReferenceHolder
    {
        private static V1 form1 = null;
        public static V1 Form1
        {
            get
            {
                if (form1 == null)
                    form1 = new V1();
                return form1;
            }
        }


        private static Verify ver = null;
        public static Verify Ver
        {
            get
            {
                if (ver == null)
                    ver = new Verify();
                return ver;
            }
        }

        private static AddLicense add_license = null;
        public static AddLicense AddLicense
        {
            get
            {
                if (add_license == null)
                    add_license = new AddLicense();
                return add_license;
            }
        }
    }

}
