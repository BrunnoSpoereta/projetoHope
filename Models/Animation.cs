namespace AppValidationLogin
{
    //Criamos uma classe static pois não é necessario instanciar a classe em memoria. Podemos chamar o método direto
    //Todos os métodos de uma classe static precisão ser static.
    //A ideia da classe é centralizar as animações do aplicativo em um unico arquivo.
    public static class Animation
    {
        //Animation tremer para coponentes visuais, ou seja, botões, label, entry, imagens, etc ...
        static public async void Tremer(VisualElement elemento)
        {
            //Primeiro preciso validar se o elemento não está nulo, ou seja, se ja foi criado
            //Se não existir abortamos a execução.
            if (elemento == null)
                return; //abortar

            //Definimops o tempo
            uint tempo = 50;

            //Lista de deslocamento para a animação
            var listaDeslocamentos = new[] { -15, 15, -10, 10, -5, 5 };

            //Loop para aplicar o deslocamento
            foreach (var deslocamento in listaDeslocamentos)
                await elemento.TranslateTo(deslocamento, 0, tempo);
            elemento.TranslationX = 0;
        }
    }
}
