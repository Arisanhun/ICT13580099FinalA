using System;
using System.Collections.Generic;
using ICT13580099FinalA.Models;
using Xamarin.Forms;

namespace ICT13580099FinalA
{
    public partial class ProfileNewPage : ContentPage
    {
        public ProfileNewPage()
        {
            InitializeComponent();
            saveButton.Clicked += SaveButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;
        }

         async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่", "ไม่ใช่");

            if(isOk)
            
            {
                var profile = new Profile();
                profile.Name = nameEntry.Text;
                profile.Surname = surnameEntry.Text;


			}
        }

        void CancelButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}