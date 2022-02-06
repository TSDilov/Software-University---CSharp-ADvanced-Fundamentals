function orbitWithNumbersInMatrix(arrayWithSizeAndCordinates) {
    let matrixRows = arrayWithSizeAndCordinates[0];
    let matrixColumns = arrayWithSizeAndCordinates[1];
    let starRowIndex = arrayWithSizeAndCordinates[2];
    let starColumnIndex = arrayWithSizeAndCordinates[3];
    let orbitMatrix = [];
    for (let i = 0; i < matrixRows; i++) {
        orbitMatrix[i] = [];   
        for(let j = 0; j < matrixColumns; j++) {
            orbitMatrix[i][j] = Math.max(Math.abs(i - starRowIndex), Math.abs(j - starColumnIndex)) + 1;
        }        
    }

    for (let row of orbitMatrix) {
        console.log(row.join(' '));
    }
    
}
orbitWithNumbersInMatrix([5, 5, 0, 0]);