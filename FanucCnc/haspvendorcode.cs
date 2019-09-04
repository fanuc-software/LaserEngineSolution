using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc
{
    public class VendorCode
    {
        /// <summary>
        /// HASP vendor code for demo keys
        /// </summary>
        private const string vendorCodeString =
            "4re3Y67Nj9w/xQc7OUK3NTDrMaAOJyJvW3F0FE9+EeQTBlqcobUbCU3koSFRjhFa0CbV2wtknAlkdYJUxx1nRDMdxe62gcthFd3M2ANh33nD9IHwLtAOG69PlT6zPrTYv3WXOC2zT4s1+Q6VW/9aU0o0bSACeY+8vd/D+3kPhg4cCtKnl5XB6VFmfyrz/6XRX21VJz5Zi40YlyefvxQfEeiYlv8D6k8I4MwP3bHxCJ+Wv0G1DXcC1ZlYp8jD8D0d9KaVRnMjMOF8uxvEodTg8T0biO/JD4VrOToSzS6fefcBDyvlCYwuHdvaeMR4ZzlZLp4Ck7GFWALliAJywYPafP9PfPAkkErPS/GaNvOFIgW0wULDsh+mZIVhSIS3zLzPHLvsli8Yblpdsg/LtPA4ikYSNQ6Ep8tuGG+c6h2ffKU5OA4XR6jCPNeRa5vM0nJmV9RJ2FOcEJnUKg/3HqoWTz71mwiRHwR2PIf0shIh6ohp/S3aUPOjFq8oai8a3tA6PgYlQ0FMEUtubA7b3C5Z3abRg/4aSKI1XM3c+K8xAsVr/k0TiH4pzi3SVJ9X9L5vyu79F57kwB+Sf+nnmR8NHi0WEHZW6yW9mYIVfMFY1WjEwwWoqtLg8kS44ZtMykvIMeXN5fiLcQQevU6CYcqECIw5ZgNVL5+SofHQhBQmPV9Xc+4+bTPYDeiJVx/+TPlnec6vlO0V1K9GgebhQHWMPk8fjz7UqR2HgAb7MPcqh+fc2F7m54CS0Bxi34zOvy7zazh9hgGzrCxrlCCy21arqvmNSwIjKqconnT7diVqFwpJiN1KIRMfMgg/s0eVoQ/Me6EjAqVwMOnLodkZ5Vb+Pybls62JGuwiWRn3+kB7G6Mbz3LsZVfZv+o+wsKJxSjsrK9y+Vo+m6oQSHIjTgRdazoR5nMMfEp+dnrsxlC7AZkNrh1H7gcDlAYlpPZI87jkgzWqg4qKF5/Abx/0EPU9dw==";

        /// <summary>
        /// Returns the vendor code as a string.
        /// </summary>
        static public string Code
        {
            get
            {
                return vendorCodeString;
            }
        }
    }
}
