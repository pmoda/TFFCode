﻿/*The table code can be found here: http://www.textfixer/resources/css-tables.php#css-table03 */

function altRows(id) 
{
    if (document.getElementsByTagName) 
    {
        var table = document.getElementById(id);
        var rows = table.getElementsByTagName("tr");

        for (i = 0; i < rows.length; i++) 
        {
            if (i % 2 == 0) 
            {
                rows[i].className = "evenrowcolor";
            } 
            else 
            {
                rows[i].className = "oddrowcolor";
            }
        }
    }
}

window.onload = function () {
    altRows('alternatecolor');
    altRows('alternatecolor1');
}