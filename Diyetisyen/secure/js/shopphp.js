function v3Ajax(act,id,pars)
{
	$.ajax({
	  url: 'ajax.php?act='+act,
	  type: 'POST',
	  data: pars,
	  success: function(data) 
			   {
				   	data = data.replace(/^\s+|\s+$/g,"");;
					$('#'+id).html(data);
						
			   }
	});	
}

function chartOdemeChange(obj)
{
	$('#chartOdemeInfo').html('<b>' + $(obj).find('option:selected').attr('adet') + '</b> adet (<b>'+$(obj).find('option:selected').attr('ciro')+' TL</b>)');	
}

function frowCheckboxClick(obj)
{
	if($(obj).find('.frow_opt').html() != '') return;
	var table = $(obj).parent().parent().parent().find('.frow_ID').attr('frowDB');
	var field = $(obj).find('.frow_val').attr('field');
	var id = $(obj).parent().parent().parent().find('.frow_ID').attr('frowID');	
	var value = $(obj).find('.frow_val').html();
	if(value.search('accept') > 0)
	{
		var url = 'ajax.php?act=updateDBField&table=' + table + '&field=' + field + '&value=0&ID='+ id +'&r='+ Math.floor(Math.random()*99999);
		$.ajax({
			'url': url,
			success: function(data) 
			{			
				$(obj).find('.frow_val').html(value.replace(/accept/i,'close'));
			}});	
	}
	else
	{
		var url = 'ajax.php?act=updateDBField&table=' + table + '&field=' + field + '&value=1&ID='+ id +'&r='+ Math.floor(Math.random()*99999);
		$.ajax({
			'url': url,
			success: function(data) 
			{			
				$(obj).find('.frow_val').html(value.replace(/close/i,'accept'));
			}});		
	}

}

function frowTextClick(obj,width)
{
	if($(obj).find('.frow_opt').html() != '') return;
	var table = $(obj).parent().parent().parent().find('.frow_ID').attr('frowDB');
	var field = $(obj).find('.frow_val').attr('field');
	var id = $(obj).parent().parent().parent().find('.frow_ID').attr('frowID');

	$('.frow_opt').html('');
	$('.frow_val').show();
	$(obj).find('.frow_val').hide();
	$('<input type="text" class="frow_input" />').css('width',(width - 2)+'px').val($(obj).find('.frow_val').text()).appendTo($(obj).find('.frow_opt')).select().focusout(
	function()
	{ 
		frowTextUpdated(obj,table,field,id); }
	).keyup(
	function(e) { 
		if(e.keyCode == 13) 
		{
			frowTextUpdated(obj,table,field,id);
			$(obj).find('.frow_opt').html('');
			$(obj).find('.frow_val').show();
		}
	});
}

function frowTextUpdated(obj,table,field,id)
{
	var value = $(obj).find('input').val();
	if(value == $(obj).find('.frow_val').text()) return;
	$(obj).find('.frow_val').html('');
	var url = 'ajax.php?act=updateDBField&table=' + table + '&field=' + field + '&value=' + value + '&ID='+ id +'&r='+ Math.floor(Math.random()*99999);
	$.ajax({
		'url': url,
		success: function(data) 
		{			
			$(obj).find('.frow_val').html(value);   
		}});	
}

function frowDbpulldownClick(obj,name,db,base)
{
	if($(obj).find('.frow_opt').html() != '') return;
	var table = $(obj).parent().parent().parent().find('.frow_ID').attr('frowDB');
	var field = $(obj).find('.frow_val').attr('field');
	var id = $(obj).parent().parent().parent().find('.frow_ID').attr('frowID');
	$('.frow_opt').html('');
	$('.frow_val').show();
	$(obj).find('.frow_val').hide();
	
	var url = 'ajax.php?act=generateOptionsList&table=' + db + '&name=' + name + '&base=' + base + '&selected='+ $(obj).find('.frow_val').text() +'&r='+ Math.floor(Math.random()*99999);
	$.ajax({
	'url': url,
	success: function(data) 
	{			
		$('<select class="frow_select"></select>').addClass('').html(data).appendTo($(obj).find('.frow_opt')).change(
			function() { 
				var value = $(this).find('option:selected').attr('value');
				var text = $(this).find('option:selected').text();
				if(text == $(obj).find('.frow_val').text()) return;
				var url = 'ajax.php?act=updateDBField&table=' + table + '&field=' + field + '&value=' + value + '&ID='+ id +'&r='+ Math.floor(Math.random()*99999);
				$.ajax({
					'url': url,
					success: function(data) 
					{			
						$(obj).find('.frow_opt').html('');
						$(obj).find('.frow_val').html(text).show();		
					}});		
			}
		);  
	}});
	
	

}

$('document').ready(function() {
	$('#textfield').autocomplete('ajax.php?act=arama',{
			minChars: 2,
			width: 300,
			multiple: false,
			matchContains: true,
			formatItem: formatItem,
			formatResult: formatResult,
			selectFirst:false
	});
	$('#textfield').keydown(function() { if($(this).val().search('.php') > 1) { var val = $(this).val(); $(this).val('yönlendiriliyor..').css('color','#ccc'); window.location.href = 's.php?f=' + val; } });
	$('#ziyaretciSelect').change(
		function() {
			chartLoaderStart(); 
			var url = 'ajax.php?act=chartZiyaretci&type='+$(this).val()+'&r='+ Math.floor(Math.random()*99999);
			$.ajax({
			'url': url,
			success: function(data) 
			{ 
				setTimeout(function() { chartLoaderStop(); },1000);
				$('.chart').html(data);						 
				v3Chart();	
							   
			}});
		
		});
	$('#ziyaretSelect').change(
		function() {
			var url = 'ajax.php?act=chartZiyaret&type='+$(this).val()+'&r='+ Math.floor(Math.random()*99999);
			$.ajax({
			'url': url,
			success: function(data) 
			{ 
				$('#enCokGezilenUrunler').html(data);						 
							   
			}});
		
		});
	$('.selectForSession').change(
		function() {
			var url = 'ajax.php?act=setSession&key='+$(this).attr('id')+'&val='+$(this).val()+'&r='+ Math.floor(Math.random()*99999);
			$.ajax({
			'url': url,
			success: function(data) 
			{ 
				// alert(data);
				return;						 							   
			}});		
		});
});

function formatItem(row) {
	return row[1];
}
function formatResult(row) {
	return row[0];	
	//return row[0].replace(/(<.+?>)/gi, '');
}

CKEDITOR.config.toolbar_Full =
[
    { name: 'document',    items : [ 'Source','-','Save','NewPage','DocProps','Preview','Print','-','Templates' ] },
    { name: 'basicstyles', items : [ 'Bold','Italic','Underline','Strike','Subscript','Superscript','-','RemoveFormat' ] },
    { name: 'clipboard',   items : [ 'Cut','Copy','Paste','PasteText','PasteFromWord','-','Undo','Redo' ] },
    { name: 'editing',     items : [ 'Find','Replace','SelectAll'] },
//    { name: 'forms',       items : [ 'Form', 'Checkbox', 'Radio', 'TextField', 'Textarea', 'Select', 'Button', 'ImageButton', 'HiddenField' ] },
    { name: 'paragraph',   items : [ 'NumberedList','BulletedList','-','Outdent','Indent','-','Blockquote','CreateDiv','-','JustifyLeft','JustifyCenter','JustifyRight','JustifyBlock','-','BidiLtr','BidiRtl' ] },
    { name: 'links',       items : [ 'Link','Unlink','Anchor' ] },
    { name: 'insert',      items : [ 'Image','Flash','Table','HorizontalRule','Smiley','SpecialChar','PageBreak' ] },
    '/',
    { name: 'styles',      items : [ 'Styles','Format','Font','FontSize' ] },
    { name: 'colors',      items : [ 'TextColor','BGColor' ] },
    { name: 'tools',       items : [ 'Maximize', 'ShowBlocks' ] }
];
CKEDITOR.config.filebrowserBrowseUrl = 'secureshare/CKEditor/filemanager/index.html';