function makeCalorieObject(arrayOfObjectData) {
    let calorieObject = {};
    for (let i = 0; i < arrayOfObjectData.length; i += 2) {
        calorieObject[arrayOfObjectData[i]] = Number(arrayOfObjectData[i + 1]);
    }
    console.log(calorieObject);
}
makeCalorieObject(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);