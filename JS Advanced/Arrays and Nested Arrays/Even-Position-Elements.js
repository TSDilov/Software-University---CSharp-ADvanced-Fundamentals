function elementsOnEvenPositionInArray(input) {
    let evenElements = '';
    for (let index = 0; index < input.length; index++) {
        if (index % 2 == 0) {
            evenElements += input[index] + ' ';
        }
    }
    console.log(evenElements);
}