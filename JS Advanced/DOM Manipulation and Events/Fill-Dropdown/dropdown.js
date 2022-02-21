function addItem() {
    let selectElement = document.getElementById('menu');
    let optionElement = document.createElement('option');
    let inputElementItem = document.getElementById('newItemText');
    optionElement.textContent = inputElementItem.value;
    let inputElementItemValue = document.getElementById('newItemValue');
    optionElement.value = inputElementItemValue.value;
 
    selectElement.appendChild(optionElement);

    inputElementItem.value = '';
    inputElementItemValue.value = '';

}