﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PIC_2018
{
    [Activity(Label = "Prevenção",
                ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    class PrevencaoActivity : Activity
    {
        //BOTÕES DA TELA
        ImageButton BUTTON_Doencas;   //21

        ButtonsInfo ButtonPressed = new ButtonsInfo();

        Intent NextActivity;

        public void LayoutFindViewById() //"Escuta" os ImageButtons
        {
            BUTTON_Doencas = FindViewById<ImageButton>(Resource.Id.BUT_Doencas);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Prevencao); //Set a tela
        }

        // ONSTART VAI AQUI //

        protected override void OnResume()
        {
            base.OnResume();
            LayoutFindViewById();

            // -- -- -- CHAMADA DE OUTRAS ACTIVITIES DE FUTURAS TELAS -- -- -- //
            BUTTON_Doencas.Click += delegate
            {
                //ButtonsInfo.LastPressed(2);
                NextActivity = new Intent(this, typeof(DoencasActivity)); //SetContentView(Resource.Layout.Promocao);
                //Finish();
                StartActivity(NextActivity);

            };
            // -- -- -- CHAMADA DE OUTRAS ACTIVITIES DE FUTURAS TELAS -- -- -- //

        }

        //BOTÃO DE VOLTAR
        public override void OnBackPressed()
        {
            Finish();
            //SetContentView(Resource.Layout.Main);

        }

    }
}