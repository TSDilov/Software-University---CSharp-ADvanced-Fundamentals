function solve() {

  document.getElementById('exercise').children[2].addEventListener('click', generateRows);
  document.getElementsByTagName('button')[1].addEventListener('click', buy)

  function generateRows() {

    const objectArray = JSON.parse(document.getElementById('exercise').children[1].value);

    for(let obj of objectArray) {

      let row = document.createElement('tr');
      const imgTdElement = document.createElement('td');
      const nameTdElement = document.createElement('td');
      const priceTdElement = document.createElement('td');
      const decorationTdElement = document.createElement('td');
      const checkboxTdElement = document.createElement('td');

      const imgElement = document.createElement('img');
      imgElement.src = obj['img'];
      imgTdElement.appendChild(imgElement);
      row.appendChild(imgTdElement);

      const nameElement = document.createElement('p');
      nameElement.textContent = obj['name'];
      nameTdElement.appendChild(nameElement);
      row.appendChild(nameTdElement);

      const priceElement = document.createElement('p');
      priceElement.textContent = obj['price'];
      priceTdElement.appendChild(priceElement);
      row.appendChild(priceTdElement);

      const decorElement = document.createElement('p');
      decorElement.textContent = obj['decFactor'];
      decorationTdElement.appendChild(decorElement);
      row.appendChild(decorationTdElement);

      const checkboxInputElement = document.createElement('input');
      checkboxInputElement.type = 'checkbox';
      checkboxTdElement.appendChild(checkboxInputElement);
      row.appendChild(checkboxTdElement);

      document.getElementsByTagName('tbody')[0].appendChild(row);
    }
  }

  function buy() {

    const arrayOfNames = [];
    const arrayOfPrices = [];
    const arrayOfDecorPoints = [];

    const arrayOfCheckboxes = Array.from(document.getElementsByTagName('input'));
    arrayOfCheckboxes.forEach(element => {

      if(element.checked) {
        arrayOfNames.push(element.parentNode.parentNode.children[1].children[0].textContent);
        arrayOfPrices.push(Number(element.parentNode.parentNode.children[2].children[0].textContent));
        arrayOfDecorPoints.push(Number(element.parentNode.parentNode.children[3].children[0].textContent));
      }
    });

    let stringOrderInfo = `Bought furniture: ${arrayOfNames.join(', ')}\nTotal price: ${arrayOfPrices.reduce((a, b) => a + b, 0).toFixed(2)}\nAverage decoration factor: ${arrayOfDecorPoints.reduce((a, b) => a + b, 0) / arrayOfDecorPoints.length}`;
    document.getElementsByTagName('textarea')[1].textContent = stringOrderInfo;
  }
}