using System;
using Course.Services;

namespace Course {
    class Factory {

        public static ITaxService CreateTaxService(string country) {
            if (country == "BRA") return new BrazilTaxService();
            if (country == "USA") return new UsaTaxService();
            throw new ArgumentException("Invalid country");
        }
    }
}
