<!DOCTYPE html>
<html lang="ar">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>صفحة بيج متعددة الصفحات</title>
    <link rel="stylesheet" href="~/css/styles.css">
</head>
<body>

    <!-- الرأس -->
    <header>
        <h1>مرحباً بك في الصفحة الرئيسية</h1>
    </header>

    <!-- التنقل بين الصفحات -->
    <nav>
        <a href="@Url.Action("Page1", "Home")">الصفحة 1</a>
        <a href="@Url.Action("Page2", "Home")">الصفحة 2</a>
        <a href="@Url.Action("Page3", "Home")">الصفحة 3</a>
    </nav>

    <div class="container">
        @RenderBody()
    </div>

    <!-- التذييل -->
    <footer>
        <p>حقوق النشر © 2025</p>
    </footer>

</body>
</html>
