function sortByTwoCriteria(array) {
    array.sort((a,b) => a.length - b.length || a.localeCompare(b));
    for (let iterator of array) {
        console.log(iterator);
    }
}
sortByTwoCriteria(['test', 
'Deny', 
'omen', 
'Default']
);