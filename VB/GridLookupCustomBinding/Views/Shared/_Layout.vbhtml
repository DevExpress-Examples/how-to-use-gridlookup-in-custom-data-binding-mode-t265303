<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8" />
    <title>@ViewBag.Title</title>

    @Html.DevExpress().GetStyleSheets( 
    new StyleSheet With { .ExtensionSuite = ExtensionSuite.GridView }, 
    new StyleSheet With { .ExtensionSuite = ExtensionSuite.Editors })
@Html.DevExpress().GetScripts( 
    new Script With { .ExtensionSuite = ExtensionSuite.NavigationAndLayout }, 
    new Script With { .ExtensionSuite = ExtensionSuite.GridView})
</head>

<body>
    @RenderBody()
</body>
</html>