function addItem() {
    let placeForAddElement = document.getElementById('items');
    let inputElement = document.getElementById('newItemText');

    let createdLiElement = document.createElement('li');
    createdLiElement.textContent = inputElement.value;
    
    let deleteElement = document.createElement('a');
    deleteElement.href = '#';
    deleteElement.textContent = '[Delete]';
    
    deleteElement.addEventListener('click', (e) => {
        createdLiElement.remove();
    })

    createdLiElement.appendChild(deleteElement);
    placeForAddElement.appendChild(createdLiElement);

    inputElement.value = '';
}