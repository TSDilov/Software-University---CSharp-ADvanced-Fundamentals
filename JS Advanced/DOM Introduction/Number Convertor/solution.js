function solve() {
    let binaryOptionElement = document.createElement('option');
    binaryOptionElement.value = 'binary';
    binaryOptionElement.innerHTML = 'Binary';
    let hexadecimalOptionElement = document.createElement('option');
    hexadecimalOptionElement.value = 'hexadecimal';
    hexadecimalOptionElement.innerHTML = 'Hexadecimal';
    document.getElementById('selectMenuTo').appendChild(binaryOptionElement);
    document.getElementById('selectMenuTo').appendChild(hexadecimalOptionElement);

    let buttonElement = document.getElementsByTagName('button')[0];
    buttonElement.addEventListener('click', () =>{
        let numberToConvert = document.getElementById('input').value;
        let selectOption = document.getElementById('selectMenuTo').value;
        let result = '';

        if (selectOption === 'binary') {
            result = Number(numberToConvert).toString(2);
        }else{
            result = Number(numberToConvert).toString(16).toUpperCase();
        }

        document.getElementById('result').value = result;
    });    
}