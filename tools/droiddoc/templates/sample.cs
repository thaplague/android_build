<?cs include:"doctype.cs" ?>
<?cs include:"macros.cs" ?>
<?cs set:resources="true" ?>
<html>
<?cs include:"head_tag.cs" ?>
<?cs include:"header.cs" ?>
<body class="gc-documentation">


<a name="top"></a>
<div class="g-unit" id="doc-content">
 <div id="jd-header" class="guide-header">
  <span class="crumb">&nbsp;</span>
  <h1><?cs var:page.title ?></h1>
 </div>

<div id="jd-content">

<p>The file containing the source code shown below is located in the corresponding directory in <code>&lt;sdk&gt;/platforms/android-&lt;version&gt;/samples/...</code></p>

<!-- begin file contents -->
<pre><?cs var:fileContents ?></pre>
<!-- end file contents -->

<?cs include:"footer.cs" ?>
</div><!-- end jd-content -->
</div> <!-- end doc-content -->

<?cs include:"trailer.cs" ?>

</body>
</html>
