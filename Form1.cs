using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
/*
 * Autor: Iordan Alexandru + Ungureanu George
 * Functionalitate: Implementare + design telecomanda
 *  -> Ungureanu George: Idee + implementare functionalitate de a adauga mecanisme ad-hoc prin intermediul OpenCloseItem (clasa cu metode virtuale)
 *  -> Iordan Alexandru: Implementare Command pe clasele specifice (light/stereo/garage)
 */
namespace Proiect_Ip
{
    public partial class Form1 : Form
    {
        //incercare de implementare a unei stive de mesaje pentru metoda UNDO
        Stack myStack = new Stack();
        //initializare command
        Command command = null;
        //invoker al claselor Light, Stereo, Garage
        SimpleRemoteControl remote = new SimpleRemoteControl();

        public Form1()
        {
            InitializeComponent();
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(btn.Text);
        }
        */

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }


        private void lightsButton_click(object sender, EventArgs e)
        {
            if (this.lightsButton.BackColor != Color.Green)
            {
                // creem o noua entitate tip light
                Light light = new Light();
                // comanda preia o entitate de tip LightOnCommand care are un obiect de tip light
                this.command = new LightOnCommand(light);
                //apelam invokerul care preia comanda si "apasa butonul"
                setCommandAndPress(command);
                //facem backgroundul verde pentru a sti ce functionalitate este pornita
                this.lightsButton.BackColor = Color.Green;
                myStack.Push(command);
            }
            else if (this.lightsButton.BackColor == Color.Green)
            {
                Light light = new Light();
                //comanda preia o entitate de tip LightOffCommand care contine textul pe care-l vom pune in textarea
                this.command = new LightOffCommand(light);
                // apelez invoker
                setCommandAndPress(command);
                //backgroundul revine la culoarea rosie => este oprita functionalitatea
                this.lightsButton.BackColor = Color.Red;
                myStack.Push(command);
            }
        }

        private void tvButton_Click(object sender, EventArgs e)
        {
            if (this.tvButton.BackColor != Color.Green)
            {
                //creare iteme ad-hoc.
                //Aceasta functionalitate este implementata cu OpenCloseItem
                //  metoda care faciliteaza crearea de obiecte noi si integrarea acestora
                //  in design pattern-ul command. Acestea impartasesc aceleasi metode
                //  ItemClose si ItemOpen care au la baza un obiect de tipul OpenCloseItem
                //  la restul claselor putem adauga metode particulare -> speaker/stereo
                OpenCloseItem television = new OpenCloseItem("Televizorul");

                this.command = new ItemOpenCommand(television);
                setCommandAndPress(command);
                
                this.tvButton.BackColor = Color.Green;
                myStack.Push(command);
            }
           else if (this.tvButton.BackColor == Color.Green)
            {
                OpenCloseItem television = new OpenCloseItem("Televizorul");
                this.command = new ItemCloseCommand(television);
                setCommandAndPress(command);
                this.tvButton.BackColor = Color.Red;
                myStack.Push(command);
            }
        }

        private void speakersButton_Click(object sender, EventArgs e)
        {
            if (this.speakersButton.BackColor != Color.Green)
            {
                Stereo stereo = new Stereo();
                this.command = new StereoOnWithCDCommand(stereo);
                setCommandAndPress(command);
                this.speakersButton.BackColor = Color.Green;
                myStack.Push(command);
            }
            else if (this.speakersButton.BackColor == Color.Green)
            {
                Stereo stereo = new Stereo();
                this.command = new StereoOffCommand(stereo);
                setCommandAndPress(command);
                this.speakersButton.BackColor = Color.Red;
                myStack.Push(command);
            }
        }

        private void garageButton_Click(object sender, EventArgs e)
        {
            if ( this.garageButton.BackColor != Color.Green)
            {
                GarageDoor garageDoor = new GarageDoor();
                this.command = new GarageDoorUpCommand(garageDoor);
                setCommandAndPress(command);
                this.garageButton.BackColor = Color.Green;
                myStack.Push(command);
            }
            else if ( this.garageButton.BackColor == Color.Green)
            {
                GarageDoor garageDoor = new GarageDoor();
                this.command = new GarageDoorDownCommand(garageDoor);
                setCommandAndPress(command);
                this.garageButton.BackColor = Color.Red;
                myStack.Push(command);
            }
        }

        private void windowsButton_Click(object sender, EventArgs e)
        {
            if (this.windowsButton.BackColor != Color.Green)
            {
                OpenCloseItem window = new OpenCloseItem("Geamul");
                this.command = new ItemOpenCommand(window);
                setCommandAndPress(command);
                this.windowsButton.BackColor = Color.Green;
                myStack.Push(command);
            }
            else if (this.windowsButton.BackColor == Color.Green)
            {
                OpenCloseItem window = new OpenCloseItem("Geamul");
                this.command = new ItemCloseCommand(window);
                setCommandAndPress(command);
                this.windowsButton.BackColor = Color.Red;
                myStack.Push(command);
            }
        }

        private void gatesButton_Click(object sender, EventArgs e)
        {
            if (this.gatesButton.BackColor != Color.Green)
            {
                OpenCloseItem gate = new OpenCloseItem("Poarta");
                this.command = new ItemOpenCommand(gate);
                setCommandAndPress(command);
                this.gatesButton.BackColor = Color.Green;
                myStack.Push(command);
            }
            else if (this.gatesButton.BackColor == Color.Green)
            {
                OpenCloseItem gate = new OpenCloseItem("Poarta");
                this.command = new ItemCloseCommand(gate);
                setCommandAndPress(command);
                this.gatesButton.BackColor = Color.Red;
                myStack.Push(command);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.logsArea.Text = "-------- Telecomanda Universala Activata --------";
        }
        // comanda o am setata in butoane
        // preiau comanda si o trimit prin simpleremotecontrol
        private void setCommandAndPress(Command command)
        {
            remote.Command = command;
            this.logsArea.Text = this.logsArea.Text + Environment.NewLine + remote.buttonWasPressed();
        }
        //buton on/off care inchide / deschide telecomanda
        private void onOffButton_CheckedChanged(object sender, EventArgs e)
        {
            Boolean enabled = this.onOffButton.Checked;
            this.logsArea.Text = "-------- Telecomanda Universala Activata --------";
            this.lightsButton.Enabled = enabled;
            this.tvButton.Enabled = enabled;
            this.garageButton.Enabled = enabled;
            this.speakersButton.Enabled = enabled;
            this.gatesButton.Enabled = enabled;
            this.windowsButton.Enabled = enabled;
            this.logsArea.Enabled = enabled;
            this.label1.Enabled = enabled;
            this.clearButton.Enabled = enabled;
            this.exc_but.Enabled = enabled;
            this.lightsButton.BackColor = Color.Red;
            this.tvButton.BackColor = Color.Red;
            this.garageButton.BackColor = Color.Red;
            this.speakersButton.BackColor = Color.Red;
            this.gatesButton.BackColor = Color.Red;
            this.windowsButton.BackColor = Color.Red;
            // daca apas pe butonul de Off ->
            if (enabled == false)
            {
                this.logsArea.Text = "";
                this.logsArea.Text = "-------- Telecomanda Universala Dezactivata --------";
                this.lightsButton.BackColor = Color.Gainsboro;
                this.tvButton.BackColor = Color.Gainsboro;
                this.garageButton.BackColor = Color.Gainsboro;
                this.speakersButton.BackColor = Color.Gainsboro;
                this.gatesButton.BackColor = Color.Gainsboro;
                this.windowsButton.BackColor = Color.Gainsboro;
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            
            //logsArea.Text = setCommandAndPress(myStack.Pop());
        }
        double a = 98;
        double result = 0;

        //metoda generare exceptii (Divide by 0)
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void button_exc(object sender, EventArgs e)
        {

            int b = RandomNumber(-1, 1);
            try
            {
                if (b == 0)
                {
                    throw new System.DivideByZeroException();
                }
                this.logsArea.Text = "Of, se pare ca nu am nimic de facut. E liniste si pace pe aici";
                result = a/b;
                //this.logsArea.Text = result.ToString();
            }
            catch (DivideByZeroException)
            {
                this.logsArea.Text= "Am prins o exceptie ! O tin bine ca sa nu-ti crape programul";
            }
        }

    }
}
