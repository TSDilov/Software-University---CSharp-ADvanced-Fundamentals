function generateReport() {
    let objectArray = [];
    let checkedColumns = [];
    let headerArray = Array.from(document.getElementsByTagName('input'));
    let trElementsArray = Array.from(document.getElementsByTagName('tr'));
    for (let i = 0; i < trElementsArray.length; i++) {
        let currentRow = trElementsArray[i];
        let currentObject = {};

        for (let j = 0; j < currentRow.children.length; j++) {
            let element = currentRow.children[j];
            if (i == 0) {
                if (element.children[0].checked) {
                    checkedColumns.push(j);
                }

                continue;
            }

            if (checkedColumns.includes(j)) {
                let propertyName = headerArray[j].name;
                currentObject[propertyName] = element.textContent;
            }           
        }
        if (i !== 0) {
            objectArray.push(currentObject);
        }
    }

    document.getElementById('output').value = JSON.stringify(objectArray);
}