function lastKNumbersSequence(n, k) {
    let sequence = [1];
    for(let i = 1; i < n; i++) {
        let temp = sequence.slice(-k);
            let sum = 0;
            temp.forEach(element => {
                sum += element;
            });
        sequence.push(sum);
    }
    return sequence;
}
console.log(lastKNumbersSequence(6, 3));
