function negativeInFrontOfPositive(input) {
    let newArray = [];
    for (let index = 0; index < input.length; index++) {
        if (input[index] >= 0) {
            newArray.push(input[index]);
        }else{
            newArray.unshift(input[index]);
        }
    }
    console.log(newArray.join('\n'));
}
negativeInFrontOfPositive([3, -2, 0, -1])