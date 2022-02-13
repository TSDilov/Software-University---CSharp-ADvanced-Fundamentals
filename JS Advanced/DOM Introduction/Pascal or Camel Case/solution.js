function solve() {
  let text = document.getElementById('text');
  let writedText = text.value;

  let convention = document.getElementById('naming-convention');
  let writedConvention = convention.value;

  let result = '';
  let textArray = writedText.split(' ');
  if (writedConvention === 'Camel Case') {
    result += (textArray[0].toLowerCase());
  }else if (writedConvention === 'Pascal Case') {
    result += (textArray[0][0].toUpperCase() + textArray[0].substring(1).toLowerCase());
  } else {
    result = 'Error!';
  }

  if (result !== 'Error!') {
    for (let i = 1; i < textArray.length; i++) {
      result += (textArray[i][0].toUpperCase() + textArray[i].substring(1).toLowerCase());
    }
  }

  let transformResult = document.getElementById('result');
  transformResult.textContent = result;
}