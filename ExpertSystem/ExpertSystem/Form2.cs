using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class Instrukcja : Form
    {
        public Instrukcja()
        {
            InitializeComponent();
            textBox1.Text = "Witamy w aplikacji - Ekspercki system doradczy,wspomagający decyzję wyboru uniwersytetu na podstawie wyników z matur \r\n" +
                "W celu skożystania z aplikaji prosimy wybrać \"Rocpocznij jako użytkownik\" i wybrać przedmioty według których nastąpi dopasowanie \r\n" +
                "Możliwe jest wybranie przedmiotów na różnych poziamach  \r\n" +
                "Zawsze podajemy: przedmiot z lisy, poziom  (Basic, Advanced) oraz wynik procentowy [0-100] \r\n" +
                "Nastepnie nalezy zatwierdzic przyciskiem Count  \r\n" +
                "Wyniki pojawiac się bedą w konsoli posortowane po prawdopodobienstwie dostania się na dany kierunek \r\n";
         }
    }
}
