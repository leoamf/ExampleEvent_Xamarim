using System;
using Xamarin.Forms;

namespace ExampleEvent_xamarim
{
    public class MainPage : ContentPage 

    {
        Button btAdd = new Button
        {
            Text = "Add new Log"
        };
        Button btDel = new Button
        {
            Text = "Delete new Log"
        }; 
        StackLayout stackChild = new StackLayout
        {
            VerticalOptions = LayoutOptions.StartAndExpand
        };

        void Bt_Clicked(object sender, EventArgs e)
        { 
            Button btSource = (Button)sender;
            if (btSource == btAdd)
            {
                Label labelDateHour = new Label
                {
                    Text = DateTime.Now.ToLongTimeString()
                };
                stackChild.Children.Add(labelDateHour);
            }
            else
            {
                stackChild.Children.RemoveAt(0);

            } 
            if (stackChild.Children.Count <= 0)
            {
                btDel.IsEnabled = false;
            } 
        }


        public MainPage()
        {

            btDel.IsEnabled = false;

            StackLayout stackBt = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand , 
                Children ={
                    btAdd,btDel
                }
            };
            btAdd.Clicked += Bt_Clicked;

            btDel.Clicked += Bt_Clicked;

            Content = new ScrollView{
                Content= new StackLayout()
                {
                    Children ={
                        stackBt,
                        stackChild
                    },
                    Padding = 30
                }
            };

              
        }
         

    }
}
