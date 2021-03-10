//var list = $('#btn_1_1_top').click(() => {
//    console.log('click me');
//}

var mergeButtons = $('.merge-btn');
for (let i = 0; i < mergeButtons.length; i++) {
    let button = mergeButtons[i];
    button.addEventListener('click', () => {
        //console.log('button pressed ' + button.id);
        MergeCell(button);
    });
}

function MergeCell(sender) {

    // find merge target
    var targetPosition = GetCoordinates(sender.attributes.grid.value);
    var type = sender.attributes.merge_type.value;

    if (type === 'left') {
        targetPosition[0] -= 1;
    } else if (type === 'top') {
        targetPosition[1] -= 1;
    }else if (type === 'right') {
        targetPosition[0] += 1;
    }else if (type === 'bottom') {
        targetPosition[1] += 1;
    }

    // validate the merge target is within bounds
    //TODO: hardfixed boundaries for now
    var assertBoundary = IsWithinBounds([0, 6, 10, 0], targetPosition);
    if (!assertBoundary) {
        console.error("Unable to merge: {Out of boundry}");
    }

    // construct id of the target
    var targetId = 'btn_' + targetPosition[0] + '_' + targetPosition[1] + '_' + type;
    var targetCell = $('#' + targetId);
    console.log(targetCell);
}

function GetCoordinates(position) {
    let coordinates = [];
    // remove extra characters
    position = position.replaceAll(' ', '');
    position = position.replaceAll('(', '');
    position = position.replaceAll(')', '');

    let point = position.split(',');
    coordinates.push(parseInt(point[0]));
    coordinates.push(parseInt(point[1]));

    return coordinates;
}

function IsWithinBounds(boundsRect, position) {
    let x = position[0]
    let y = position[1];

    let top = boundsRect[0];
    let right = boundsRect[1];
    let bottom = boundsRect[2];
    let left = boundsRect[3];

    return (x < right && x >= left && y < bottom && y >= top);
}