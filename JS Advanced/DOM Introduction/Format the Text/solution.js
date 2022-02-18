function solve() {
  let textElement = document.getElementById('input');
  let textArray = textElement.value.split('.').filter(s => s !== '');
  let result = document.getElementById('output');

  while (textArray.length > 0) {
    let text = textArray.splice(0,3).join('.') + '.';
    let pElement = document.createElement('p');
    pElement.textContent = text;
    result.appendChild(pElement);
  }
}