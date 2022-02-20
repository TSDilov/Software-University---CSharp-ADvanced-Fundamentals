function addItem() {
    let inputElement = document.getElementById('newItemText');
    let newElement = document.createElement('li');
    newElement.textContent = inputElement.value;
    let whereToAddElement = document.getElementById('items');
    whereToAddElement.appendChild(newElement);
}