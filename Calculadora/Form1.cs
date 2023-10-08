using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string equation = null; //O valor que vai aparecer na label
        double value1 = 0; //O valor atual que esta em operação
        double value2 = 0; //O valor que esta sendo digitado 
        bool checking = false; //Verificador para seu alguum numero ja foi digitado 
        char operation = ' '; //A varial que vai definir a operação
        bool turnBack = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_one_Click(object sender, EventArgs e)
        {
            if (equation != null) //Verifica se tem algum valor ja digitado
            {// se sim
                equation = equation + "1"; //Cancatena o valor atual com "1"
            }
            else if (turnBack) //Verifica se esta digitando sobre uma conta ja realizada
            {
                bt_Clear_Click(sender, e);
                equation = "1";
            }
            else//se não
            {
                equation = "1"; // Atrubui "1" para equation
            }
            label_equation.Text = equation; //Escreve o valor do "equation" na label
        } //Escreve "1" na operação

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            //Limpa e zera todos os valores envolvidos na operação
            label_equation.Text = "";
            label_historic.Text = "";
            equation = null;
            checking = false;
            turnBack = false;
            value1 = 0;
            value2 = 0;
            operation =' ';
        } //Limpa a equação e o estorico

        private void bt_two_Click(object sender, EventArgs e)
        {
            if (equation != null) //Verifica se tem algum valor ja digitado
            {// se sim
                equation = equation + "2"; //Cancatena o valor atual com "2"
            }
            else if (turnBack) //Verifica se esta digitando sobre uma conta ja realizada
            {
                bt_Clear_Click(sender, e);
                equation = "2";
            }
            else//se não
            {
                equation = "2"; // Atrubui "2" para equation
            }
            label_equation.Text = equation; //Escreve o valor do "equation" na label
        } //Escreve "2" na operação

        private void bt_three_Click(object sender, EventArgs e)
        {
            if (equation != null) //Verifica se tem algum valor ja digitado
            {// se sim
                equation = equation + "3"; //Cancatena o valor atual com "3"
            }
            else if (turnBack) //Verifica se esta digitando sobre uma conta ja realizada
            {
                bt_Clear_Click(sender, e);
                equation = "3";
            }
            else//se não
            {
                equation = "3"; // Atrubui "3" para equation
            }
            label_equation.Text = equation; //Escreve o valor do "equation" na label
        } //Escreve "3" na operação

        private void bt_four_Click(object sender, EventArgs e)
        {
            if (equation != null) //Verifica se tem algum valor ja digitado
            {// se sim
                equation = equation + "4"; //Cancatena o valor atual com "4"
            }
            else if (turnBack) //Verifica se esta digitando sobre uma conta ja realizada
            {
                bt_Clear_Click(sender, e);
                equation = "4";
            }
            else//se não
            {
                equation = "4"; // Atrubui "4" para equation
            }
            label_equation.Text = equation; //Escreve o valor do "equation" na label
        } //Escreve "4" na operação

        private void bt_five_Click(object sender, EventArgs e)
        {
            if (equation != null) //Verifica se tem algum valor ja digitado
            {// se sim
                equation = equation + "5"; //Cancatena o valor atual com "5"
            }
            else if (turnBack) //Verifica se esta digitando sobre uma conta ja realizada
            {
                bt_Clear_Click(sender, e);
                equation = "5";
            }
            else//se não
            {
                equation = "5"; // Atrubui "5" para equation
            }
            label_equation.Text = equation; //Escreve o valor do "equation" na label
        } //Escreve "5" na operação

        private void bt_six_Click(object sender, EventArgs e)
        {
            if (equation != null) //Verifica se tem algum valor ja digitado
            {// se sim
                equation = equation + "6"; //Cancatena o valor atual com "6"
            }
            else if (turnBack) //Verifica se esta digitando sobre uma conta ja realizada
            {
                bt_Clear_Click(sender, e);
                equation = "6";
            }
            else//se não
            {
                equation = "6"; // Atrubui "6" para equation
            }
            label_equation.Text = equation; //Escreve o valor do "equation" na label
        } //Escreve "6" na operação

        private void bt_seven_Click(object sender, EventArgs e)
        {
            if (equation != null) //Verifica se tem algum valor ja digitado
            {// se sim
                equation = equation + "7"; //Cancatena o valor atual com "7"
            }
            else//se não
            {
                equation = "7"; // Atrubui "7" para equation
            }
            label_equation.Text = equation; //Escreve o valor do "equation" na label
        } //Escreve "7" na operação

        private void bt_eight_Click(object sender, EventArgs e)
        {
            if (equation != null) //Verifica se tem algum valor ja digitado
            {// se sim
                equation = equation + "8"; //Cancatena o valor atual com "8"
            }
            else if (turnBack) //Verifica se esta digitando sobre uma conta ja realizada
            {
                bt_Clear_Click(sender, e);
                equation = "8";
            }
            else//se não
            {
                equation = "8"; // Atrubui "8" para equation
            }
            label_equation.Text = equation; //Escreve o valor do "equation" na label
        } //Escreve "8" na operação

        private void bt_nine_Click(object sender, EventArgs e)
        {
            if (equation != null) //Verifica se tem algum valor ja digitado
            {// se sim
                equation = equation + "9"; //Cancatena o valor atual com "9"
            }
            else if (turnBack) //Verifica se esta digitando sobre uma conta ja realizada
            {
                bt_Clear_Click(sender, e);
                equation = "9";
            }
            else//se não
            {
                equation = "9"; // Atrubui "9" para equation
            }
            label_equation.Text = equation; //Escreve o valor do "equation" na label
        } //Escreve "9" na operação

        private void bt_zero_Click(object sender, EventArgs e)
        {
            if (equation != null)//Verifica se tem algum valor ja digitado
            {
                equation = equation + "0";//Cancatena o valor atual com "0"
            }
            else if (turnBack) //Verifica se esta digitando sobre uma conta ja realizada
            {
                bt_Clear_Click(sender, e);
                equation = "1";
            }
            else 
            { 
                equation = "0"; 
            }
            label_equation.Text = equation;
        } //Escreve "0" na operação

        private void bt_comma_Click(object sender, EventArgs e)
        {
            
            if (equation != null) //Verifica se algum numero ja foi digitado
            {
                char[] verification = equation.ToCharArray();
                bool dec = true;
                for (int i = 0; i < verification.Length; i++)
                {
                    if (verification[i] == ',')
                    {
                        dec = false;
                    }
                }
                if (dec)
                {
                    equation += ",";
                }
                
            }
            else
            {
                equation = "0,";
            }
            
            label_equation.Text = equation;
        } //Diciona um "," a equação

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (equation != null && equation != "0,") //Verifica oq esta esta escrito na labal
            {
                char[] verification = equation.ToCharArray(); //Transforma "equation" em um Array
                equation = null; //Limpa "equation"
                for (int i = 0;i < verification.Length-1;i++) //Roda todos os elementos do Array, menos o ultimo
                {
                    equation += verification[i]; //Cancatena todos termos que rodaram
                }
            }
            else if (equation == "0,") //Se oq tiver escrito na labal for "0,"
            {
                equation = null; //Limpa "equation"
            }
            label_equation.Text = equation; //Atulaiza a label
        } //Apaga o ultimo termo escrito

        private void bt_division_Click(object sender, EventArgs e)
        {
            if (!checking)//Verifica se algum valor foi digitado anteriomente 
            { // Se nenhum numero foi digitas
                value1 = double.Parse(equation); //O valor de "equation" vai se atribuido  a "value1"
                equation = null; //Limpa o valor de "equation"
                label_equation.Text = equation; // Limpa o texto na label
                checking = true; //Marca disendo que um numero ja foi registrato
            }
            else if (checking  && equation == null && operation != ' ')
            {
                operation = '/';
                turnBack = false;
                label_equation.Text = equation; // Limpa o texto na label
            }
            else
            {//Se ja tiver algum valor atribuido a "value1"
                value2 = double.Parse(equation);//O valor de "equation" vai se atribuido  a "value2"
                if (value2 == 0) //Verifica se o dividendo tem valor nulo
                {
                    MessageBox.Show("Erro! Não se pode dividir por valor nulo"); //Avisa que a divisão é imposivel 
                }
                else if (operation == '/')// Verifica se a operação anterior foi uma divisão
                {
                     value1 /= value2; //Realiza a operação
                }
                else if (operation == '*')// Verifica se a operação anterior foi uma multiplicação
                {
                     value1 *= value2;//Realiza a operação
                }
                else if (operation == '-')// Verifica se a operação anterior foi uma subtração
                {
                     value1 -= value2;//Realiza a operação
                }
                else if (operation == '+')// Verifica se a operação anterior foi uma soma
                {
                    value1 += value2;//Realiza a operação
                }
                equation = null;//Limpa o valor de "equation"
                label_equation.Text = value1.ToString();//Printa o valor atual na label
            }
            operation = '/'; //Define a proxima operação com divição
            label_historic.Text = value1.ToString() + operation; //Atualiza o historico de contas
            
            
        } //Realiza a operação de divisão

        private void bt_enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (equation != null) //verifoca se tem alguma valor atribuido para "equation"
                {
                    value2 = double.Parse(equation); //Pega o valor que esta na label e atribui ao "value2"
                    if (operation == '/') //Se a operação for uma divisão
                    {
                        if (value2 == 0) //Verifoca se o diveidendo ne nulo
                        {
                            MessageBox.Show("Erro! Não se pode dividir por valor nulo"); //Avisa que o dividendo não pode ser nulo
                        }
                        else // Se não, esecuta a operação
                        {
                            equation = (value1 / value2).ToString();
                        }

                    }
                    else if (operation == '*') //Verifica qual a operação pedida
                    {
                        equation = (value1 * value2).ToString();
                    }
                    else if (operation == '-')//Verifica qual a operação pedida
                    {
                        equation = (value1 - value2).ToString();
                    }
                    else if (operation == '+')//Verifica qual a operação pedida
                    {
                        equation = (value1 + value2).ToString();
                    }

                }
                label_equation.Text = equation; // Atualisa a label com o valor da conta
                label_historic.Text = value1.ToString() + operation + value2.ToString(); //Atualiza o historico de contas
                value1 = double.Parse(equation); //Atrubui o valor 
                equation = null; value2 = 0; //Reinicia os valores
                turnBack = true;//Declara que a conta foi finalizada
            }
            catch // se o usuario  cricar mais de uma vez o 'enter' 
            {
                label_equation.Text = null;
                label_historic.Text = value1.ToString();
            }
               
        } //Finali a conta com a operação pedida 

        private void bt_multiplication_Click(object sender, EventArgs e)
        {
            if (!checking)//Verifica se algum valor foi digitado anteriomente 
            { // Se nenhum numero foi digitas
                value1 = double.Parse(equation); //O valor de "equation" vai se atribuido  a "value1"
                equation = null; //Limpa o valor de "equation"
                label_equation.Text = equation; // Limpa o texto na label
                checking = true; //Marca disendo que um numero ja foi registrato
            }
            else if (checking && equation == null && operation != ' ') // Verica se o usuaria que apenas trovar a operação
            {
                operation = '*';
                turnBack = false;
                label_equation.Text = equation; // Limpa o texto na label
            }
            else
            {//Se ja tiver algum valor atribuido a "value1"
                value2 = double.Parse(equation);//O valor de "equation" vai se atribuido  a "value2"
                if (operation == '/')// Verifica se a operação anterior foi uma divisão
                {
                    if (value2 == 0) //Verifoca se o diveidendo ne nulo
                    {
                        MessageBox.Show("Erro! Não se pode dividir por valor nulo"); //Avisa que o dividendo não pode ser nulo
                    }
                    else // Se não, esecuta a operação
                    {
                        value1 /= value2; //Realiza a operação
                    }
                }
                else if (operation == '*')// Verifica se a operação anterior foi uma multiplicação
                {
                    value1 *= value2;//Realiza a operação
                }
                else if (operation == '-')// Verifica se a operação anterior foi uma subtração
                {
                    value1 -= value2;//Realiza a operação
                }
                else if (operation == '+')// Verifica se a operação anterior foi uma soma
                {
                    value1 += value2;//Realiza a operação
                }
                equation = null;//Limpa o valor de "equation"
                label_equation.Text = value1.ToString();//Printa o valor atual na label
            }
            operation = '*'; //Define a proxima operação com multiplicação
            label_historic.Text = value1.ToString() + operation; //Atualiza o historico de contas
        } //Realiza a operação de multiplicação

        private void bt_subtraction_Click(object sender, EventArgs e)
        {
            if (!checking)//Verifica se algum valor foi digitado anteriomente 
            { // Se nenhum numero foi digitas
                value1 = double.Parse(equation); //O valor de "equation" vai se atribuido  a "value1"
                equation = null; //Limpa o valor de "equation"
                label_equation.Text = equation; // Limpa o texto na label
                checking = true; //Marca disendo que um numero ja foi registrato
            }
            else if (checking && equation == null && operation != ' ') // Verica se o usuaria que apenas trovar a operação
            {
                operation = '-';
                turnBack = false;
                label_equation.Text = equation; // Limpa o texto na label
            }
            else
            {//Se ja tiver algum valor atribuido a "value1"
                value2 = double.Parse(equation);//O valor de "equation" vai se atribuido  a "value2"
                if (operation == '/')// Verifica se a operação anterior foi uma divisão
                {
                    if (value2 == 0) //Verifoca se o diveidendo ne nulo
                    {
                        MessageBox.Show("Erro! Não se pode dividir por valor nulo"); //Avisa que o dividendo não pode ser nulo
                    }
                    else // Se não, esecuta a operação
                    {
                        value1 /= value2; //Realiza a operação
                    }
                }
                else if (operation == '*')// Verifica se a operação anterior foi uma multiplicação
                {
                    value1 *= value2;//Realiza a operação
                }
                else if (operation == '-')// Verifica se a operação anterior foi uma subtração
                {
                    value1 -= value2;//Realiza a operação
                }
                else if (operation == '+')// Verifica se a operação anterior foi uma soma
                {
                    value1 += value2;//Realiza a operação
                }
                equation = null;//Limpa o valor de "equation"
                label_equation.Text = value1.ToString();//Printa o valor atual na label
            }
            operation = '-'; //Define a proxima operação com multiplicação
            label_historic.Text = value1.ToString() + operation; //Atualiza o historico de contas
        } //Realiza a operação de subtração

        private void bt_sum_Click(object sender, EventArgs e)
        {
            if (!checking)//Verifica se algum valor foi digitado anteriomente 
            { // Se nenhum numero foi digitas
                value1 = double.Parse(equation); //O valor de "equation" vai se atribuido  a "value1"
                equation = null; //Limpa o valor de "equation"
                label_equation.Text = equation; // Limpa o texto na label
                checking = true; //Marca disendo que um numero ja foi registrato
            }
            else if (checking && equation == null && operation != ' ') // Verica se o usuaria que apenas trovar a operação
            {
                operation = '+';
                turnBack = false;
                label_equation.Text = equation; // Limpa o texto na label
            }
            else
            {//Se ja tiver algum valor atribuido a "value1"
                value2 = double.Parse(equation);//O valor de "equation" vai se atribuido  a "value2"
                if (operation == '/')// Verifica se a operação anterior foi uma divisão
                {
                    if (value2 == 0) //Verifoca se o diveidendo ne nulo
                    {
                        MessageBox.Show("Erro! Não se pode dividir por valor nulo"); //Avisa que o dividendo não pode ser nulo
                    }
                    else // Se não, esecuta a operação
                    {
                        value1 /= value2; //Realiza a operação
                    }
                }
                else if (operation == '*')// Verifica se a operação anterior foi uma multiplicação
                {
                    value1 *= value2;//Realiza a operação
                }
                else if (operation == '-')// Verifica se a operação anterior foi uma subtração
                {
                    value1 -= value2;//Realiza a operação
                }
                else if (operation == '+')// Verifica se a operação anterior foi uma soma
                {
                    value1 += value2;//Realiza a operação
                }
                equation = null;//Limpa o valor de "equation"
                label_equation.Text = value1.ToString();//Printa o valor atual na label
            }
            operation = '+'; //Define a proxima operação com multiplicação
            label_historic.Text = value1.ToString() + operation; //Atualiza o historico de contas
        } //Realiza a operação de soma
    }
}
    

