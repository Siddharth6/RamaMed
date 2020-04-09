



var content = "<div>";

for (var k in formitem) {

    //content = content.concat(
    //    "<div class='col-md-6 px-5 py-2'><div class='row'>" +
    //    "<label class='col-7 form-label text-capitalize'>" + formitem[k].title + "</label>"
    //);
    //if (formitem[k].inputType == 1) {
    //    content = content.concat(
    //        "<input class='col-5 form-control' type='text' placeholder='" + formitem[k].inputOptions + "' asp-for='" + formitem[k].title + "'>"
    //    );
    //}
    //else if (formitem[k].inputType == 2) {
    //    content = content.concat("<input type='checkbox' class='' value=''" + formitem[k].inputOptions + ">");
    //}
    //content = content.concat("</div></div>");


    content = content.concat(
        "<div class='px-5 py-2'>" +
        "<div class='row border-bottom'>" +
        "<label class='form-label text-capitalize col-4'>" + formitem[k].title + "</label>"
    );


    //applying _ in place of the spaces in title 


    titles = formitem[k].title.split(" ");
    var temp_aspfor = formitem[k].title;

    if (titles.length > 1) {
        temp_aspfor = "";
        for (var i = 0; i < titles.length; i++) {
            if (i != 0) {
                temp_aspfor = temp_aspfor.concat("_");
            }
            temp_aspfor = temp_aspfor.concat(titles[i]);
        }
    }
    console.log(temp_aspfor);
    // for input boxes
    var aspfor = "";

    //for textboxes
    if (formitem[k].inputType == 1) {
        //applying _ in place of the spaces in options 
        var options = formitem[k].inputOptions.split(",");
        for (var i = 0; i < options.length; i++) {
            var col = (8 / options.length) / 2;
            aspfor = "";
            aspfor = temp_aspfor.concat("_" + options[i]).toUpperCase();
            //content = content.concat("<div class='col-8'>");
            content = content.concat("<label class='form-label col-" + col + "'>" + options[i] + "</label>");
            content = content.concat("<input asp-for='" + aspfor + "' class='form-control mb-3 col-" + col + "' type='text'>");
            //content = content.concat("</div'>");
        }
    }
    //for checkboxes
    else if (formitem[k].inputType == 2) {
        var aspfor = temp_aspfor.toUpperCase();
        //applying _ in place of the spaces in options 
        var options = formitem[k].inputOptions.split(",");
        for (var i = 0; i < options.length; i++) {
            var col = (8 / options.length) / 2;
            //content = content.concat("<div class='col-8'>");
            content = content.concat("<label class='form-label col-" + col + "'>" + options[i]);
            content = content.concat("<input class='mb-3 col-" + col + "' type='checkbox' asp-for='" + aspfor + "' value='" + options[i] + "'>" + "</label>");
            //content = content.concat("</div'>");
        }
    }
    //for textareas
    else if (formitem[k].inputType == 3) {
        content = content.concat("<input class='' type='textarea' rows='15' cols='30'>")
    }
    content = content.concat("</div></div>");

}

content = content.concat("</div>");
//console.log(content);
document.getElementById("form-content").innerHTML = content;