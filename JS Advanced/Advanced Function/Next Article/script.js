function getArticleGenerator(articles) {
    function nextArticle() {
        if (articles.length > 0) {
            let currentArticle = document.createElement('article');
            currentArticle.textContent = articles.shift();
            document.getElementById('content').appendChild(currentArticle);
        }
    }

    return nextArticle;
}
