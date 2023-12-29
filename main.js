// Simulando dados de artigos
const articles = [
    { title: 'Título do Artigo 1', content: 'Conteúdo do Artigo 1...' },
    { title: 'Título do Artigo 2', content: 'Conteúdo do Artigo 2...' },
    // Adicione mais artigos conforme necessário
];

let currentArticleIndex = 0;

const articleContainer = document.getElementById('articleContainer');
const loadMoreBtn = document.getElementById('loadMoreBtn');

function loadArticle(index) {
    const article = articles[index];
    if (article) {
        articleContainer.innerHTML = `<h2>${article.title}</h2><p>${article.content}</p>`;
    }
}

function loadNextArticle() {
    currentArticleIndex++;
    loadArticle(currentArticleIndex);
}

loadMoreBtn.addEventListener('click', loadNextArticle);

// Carregar o primeiro artigo ao carregar a página
loadArticle(currentArticleIndex);
