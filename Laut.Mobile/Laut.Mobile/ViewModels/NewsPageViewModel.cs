using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laut.Mobile.ViewModels
{
    public class NewsPageViewModel : BindableBase
    {
        private List<News> _news;
        public List<News> News
        {
            get { return _news; }
            set { SetProperty(ref _news, value); }
        }

        public NewsPageViewModel()
        {
            News = new List<ViewModels.News>();

            News.Add(new ViewModels.News
            {
                Title = "Congresso de alguma coisa",
                SubTitle = "Alguma outra coisa mais legal",
                Image = "teste.png"
            });
            News.Add(new ViewModels.News
            {
                Title = "Congresso de alguma coisa",
                SubTitle = "Alguma outra coisa mais legal",
                Image = "teste.png"
            });
            News.Add(new ViewModels.News
            {
                Title = "Congresso de alguma coisa",
                SubTitle = "Alguma outra coisa mais legal",
                Image = "teste.png"
            });
            News.Add(new ViewModels.News
            {
                Title = "Congresso de alguma coisa",
                SubTitle = "Alguma outra coisa mais legal",
                Image = "teste.png"
            });
            News.Add(new ViewModels.News
            {
                Title = "Congresso de alguma coisa",
                SubTitle = "Alguma outra coisa mais legal",
                Image = "teste.png"
            });
        }
    }

    public class News
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Image { get; set; }
    }
}
