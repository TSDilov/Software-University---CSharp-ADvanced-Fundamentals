function sumTable() {
    let tableElements = document.getElementsByTagName('tr');
    let sum = 0;
    for (let i = 1; i < tableElements.length - 1; i++) {
        let number = Number(tableElements[i].querySelectorAll('td')[1].textContent);
        sum += number;
    }

    document.getElementById('sum').textContent = sum;
}