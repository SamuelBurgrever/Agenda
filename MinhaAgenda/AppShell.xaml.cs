﻿using MinhaAgenda.Views;

namespace MinhaAgenda
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ContatosPage), typeof(ContatosPage));
            Routing.RegisterRoute(nameof(EditarContatoPage), typeof(EditarContatoPage));
            Routing.RegisterRoute(nameof(AdicionarContatoPage), typeof(AdicionarContatoPage));
            Routing.RegisterRoute(nameof(ContatosObsPage), typeof(ContatosObsPage));
            Routing.RegisterRoute(nameof(AdicionarContatoOBSPage), typeof(AdicionarContatoOBSPage));
        }
    }
}