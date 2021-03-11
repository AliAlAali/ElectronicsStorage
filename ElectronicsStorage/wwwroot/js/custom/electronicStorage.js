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
    } else if (type === 'right') {
        targetPosition[0] += 1;
    } else if (type === 'bottom') {
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

    var mDrawer = sender.closest('.drawer-editable');
    var column = mDrawer.parentElement;
    column.rowspan = 2;
    var targetDrawer = targetCell.closest('.drawer-editable');

    var allTargets = GetAllTargets(sender);
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

function GetAllTargets(sender) {

    var targets = [];

    // get origin position
    var orgPos = GetCoordinates(sender.attributes.grid.value);
    var orgCol = sender.parentElement;
    var type = sender.attributes.merge_type.value;
    var hOffset = orgCol.colSpan - 1;
    var vOffset = orgCol.rowSpan - 1;

    if (type === 'right') {
        hOffset += 1;
    } else if (type === 'bottom') {
        vOffset += 1;
    }

    var drawers = $('.drawer-editable');
    for (i in drawers) {
        let d = drawers[i];
        let btn = $('#' + d.id).find('.merge-btn');
        let jbtn = $('#' + btn[0].id);
        let pos = GetCoordinates(jbtn[0].attributes.grid.value);
        var debug = 1;

        if (IsWithinBounds([orgPos[1], orgPos[0] + hOffset, orgPos[1] + vOffset, orgPos[0]], pos)) {
            targets.push(d);
        }
    }

    return targets;
}

function FindCriticalTarget(targets) {
    // finds the left-top corner drawer in the merge
    // assume targets are not empty

    var minimum = PositionScore(targets[0]);
    var critial = undefined;
    for (i in targets) {
        var t = targets[i];
        var score = PositionScore(t);

        if (score <= minimum) {
            minimum = score;
            critial = t;
        }
    }

    return critial;
}

function PositionScore(target) {
    return target.attributes.colspan + target.attributes.rowspan;
}