function squareOfStars(sizeOfSquare = 5) {
    let line = '';
    for (let i = 0; i < sizeOfSquare; i++) {
        for (let j = 0; j < sizeOfSquare; j++) {
            line += `* `;
        }
        console.log(line);
        line = '';
    }
}
squareOfStars(3);