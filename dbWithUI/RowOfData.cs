using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbWithUI
{
    class RowOfData
    {
        public object id { get; set; }
        public object full_name { get; set; }
        public object age { get; set; }
        public object sex { get; set; }
        public object experience { get; set; }
        public object education { get; set; }
        public object medical_card { get; set; }
        public object car { get; set; }

        // konstruktory
        public RowOfData() { }
        public RowOfData(object _id, object _full_name, object _age, object _sex, object _experience, object _education, object _medical_card, object _car)
        {
            id = _id;
            full_name = _full_name;
            age = _age;
            sex = _sex;
            experience = _experience;
            education = _education;
            medical_card = _medical_card;
            car = _car;
        }
        public void DataChange(object _id, object _full_name, object _age, object _sex, object _experience, object _education, object _medical_card, object _car)
        {
            id = _id;
            full_name = _full_name;
            age = _age;
            sex = _sex;
            experience = _experience;
            education = _education;
            medical_card = _medical_card;
            car = _car;
        }
    }
}
