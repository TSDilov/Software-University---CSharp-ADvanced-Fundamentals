function solve() {
    let nameInputElement = document.getElementById('container').children[0];
    let hallInputElement = document.getElementById('container').children[1];
    let priceInputElement = document.getElementById('container').children[2];

    let onScreenButtonElement = document.querySelector('#container button');
    onScreenButtonElement.addEventListener('click', addMovie);

    let sectionMoviesUlElement = document.querySelector('#movies ul');
    let sectionArchivesULElement = document.querySelector('#archive ul');

    let clearButtonElement = document.querySelector('#archive button');
    clearButtonElement.addEventListener('click', clearArchive);

    function addMovie(event) {
        event.preventDefault();

        if (nameInputElement.value && hallInputElement.value && Number(priceInputElement.value)) {

           let liElement = document.createElement('li');
           let spanElement = document.createElement('span');
           spanElement.textContent = nameInputElement.value;
           liElement.appendChild(spanElement);
           let strongElement = document.createElement('strong');
           strongElement.textContent = `Hall: ${hallInputElement.value}`;
           liElement.appendChild(strongElement);
           let divElement = document.createElement('div');
           let strongElementForPrice = document.createElement('strong');
           strongElementForPrice.textContent = Number(priceInputElement.value).toFixed(2);
           divElement.appendChild(strongElementForPrice);
           let inputElement = document.createElement('input');
           inputElement.placeholder = 'Tickets Sold';
           divElement.appendChild(inputElement);
           let buttonElement = document.createElement('button');
           buttonElement.textContent = 'Archive';
           buttonElement.addEventListener('click', archiveMovie);
           divElement.appendChild(buttonElement);
           liElement.appendChild(divElement);
           sectionMoviesUlElement.appendChild(liElement);
        }

        nameInputElement.value = '';
        hallInputElement.value = '';
        priceInputElement.value  = '';

        function archiveMovie(event) {
            if (event.target.parentNode.children[1].value && Number(event.target.parentNode.children[1].value) >= 0) {
                let movieLiElement = event.target.parentNode.parentNode;
                let newLiElement = document.createElement('li');
                let spanElement = document.createElement('span');
                spanElement.textContent = movieLiElement.children[0].textContent;
                newLiElement.appendChild(spanElement);
                let strongElement = document.createElement('strong');
                strongElement.textContent = `Total amount: ${(Number(event.target.parentNode.children[1].value) 
                                                            * Number(movieLiElement.children[2].children[0].textContent)).toFixed(2)}`;
                newLiElement.appendChild(strongElement);
                let deleteButtonElement = document.createElement('button');
                deleteButtonElement.textContent = 'Delete';
                deleteButtonElement.addEventListener('click', (event) => event.target.parentNode.remove());
                newLiElement.appendChild(deleteButtonElement);
                sectionArchivesULElement.appendChild(newLiElement);
                movieLiElement.remove();
            }
        }
    }

    function clearArchive(event) {
        let archiveList = Array.from(sectionArchivesULElement.children);
        archiveList.forEach(el => el.remove());
    }
}