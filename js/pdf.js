        // Xóa thẻ nếu tồn tại
        
        //Loader
        const loader = document.getElementById('loader');
        const flipLoader = document.getElementById('flipbook');
        const btn_next = document.getElementById('next');
        const btn_prev = document.getElementById('previous');
        //File pdfpdf
        const fileInput = document.getElementById("file-input");
        //let flipbook = document.getElementById("flipbook");
        const remove = document.getElementById("remove");
        let renderedPages = 0;
        let  viewport = 0;
        let aspectRatio_cavas = 0;

        
        
        //  Sử dụng loader khi bắt đầu quá trình tải
        function showLoader() {
            loader.style.display = 'block'; // Hiển thị loader
            flipLoader.style.display = 'none'; // Ẩn flipbook trong lúc tải
            btn_next.style.display = 'none'
            btn_prev.style.display = 'none'
            fileInput.disabled = true;
        }
        
        // Ẩn loader khi hoàn tất
        function hideLoader() {
            loader.style.display = 'none';  // Ẩn loader
            flipLoader.style.display = 'block'; // Hiển thị flipbook
            btn_next.style.display = 'inline'
            btn_prev.style.display = 'inline'
        }
      

        function resize_flipbook(){
            $(window).width(function(){
                var win = $(this); //this = window
                
                var win_width = window.innerWidth ;
                var win_height = window.innerHeight ;
                //var aspectRatio = win_width / win_height;
                //alert(win_width + "," + win_height);
                //$("#flipbook").turn({width: win});
                var newWidth = 0;
                var newHeight = 0;
               
                // if(aspectRatio_cavas >= 1){
                //     newWidth = win_width * 80 /100;
                //     newHeight = win_width * 80 / 100 / aspectRatio_cavas;
                // }
                // else{
                //     newWidth = win_width * 80 /100 * aspectRatio_cavas ;
                //     newHeight = win_width * 80 /100  ;
                // }
                 if(win_width >= 800){
                    if(aspectRatio_cavas >= 1){
                        newWidth = win_width * 80 /100;
                        newHeight = win_width * 80 / 100 / aspectRatio_cavas;
                    }
                    else{
                        newWidth = win_width * 80 /100 * aspectRatio_cavas ;
                        newHeight = win_width * 80 /100  ;
                    }
                }
                else{
                    if(aspectRatio_cavas >= 1){
                        newWidth = win_width * 95 /100;
                        newHeight = win_width * 95 / 100 / aspectRatio_cavas;
                    }
                    else{
                        newWidth = win_width * 95 /100 * aspectRatio_cavas ;
                        newHeight = win_width * 95 /100  ;
                    }
                }
                    // $("#flipbook").turn('display','double');
                    // $("#flipbook").turn('size', newWidth ,newHeight / 2 );
                // }
                // else{
                //     $("#flipbook").turn('display','single');
                //     $("#flipbook").turn('size', newWidth ,newHeight );
                // }
                if(win_width > win_height && win_height <= 500 && aspectRatio_cavas > 1){
                    win_width = win_height;
                    if(aspectRatio_cavas >= 1){
                        newWidth = win_width ;
                        newHeight = win_width / aspectRatio_cavas;
                    }
                    else{
                        newWidth = win_width * aspectRatio_cavas ;
                        newHeight = win_width  ;
                    }
                    //if(win_width >= 800){
                        // $("#flipbook").turn('display','double');
                        // $("#flipbook").turn('size', newWidth ,newHeight / 2 );
                    // }
                    // else{
                    //     $("#flipbook").turn('display','single');
                    //     $("#flipbook").turn('size', newWidth ,newHeight );
                    // }
                }
                if(win_width > win_height && win_height <= 800 && aspectRatio_cavas < 1){
                    win_width = win_height;
                    if(aspectRatio_cavas >= 1){
                        newWidth = win_width ;
                        newHeight = win_width  / aspectRatio_cavas;
                    }
                    else{
                        newWidth = win_width  * aspectRatio_cavas ;
                        newHeight = win_width   ;
                    }
                    //if(win_width >= 800){
                        
                    // }
                    // else{
                    //     $("#flipbook").turn('display','single');
                    //     $("#flipbook").turn('size', newWidth ,newHeight );
                    // }
                }
                $("#flipbook").turn('display','double');
                $("#flipbook").turn('size', newWidth ,newHeight / 2 );
              });
        }
        $(document).ready(function() {
            var flipbook_count = $("#flipbook");
            

            $("#next").click(function()
            {
                $("#flipbook").turn('next');
                
            });
                $("#previous").click(function()
            {
                $("#flipbook").turn('previous');
            });
            
            window.addEventListener('resize',function(){
                $('#flipbook_zoom').zoom('zoomOut');
                this.setTimeout(function()
                    {
                        if ($('#flipbook').turn('is')) {
                    
                            resize_flipbook();
                        }
                    },1000
                )
                
                }); 
            // Kiểm tra xem flipbook đã được tạo chưa
            flipbook_count.on('load', function() {
                 // Gọi lại sự kiện resize khi trang web vừa tải xong
                window.dispatchEvent(new Event('resize'));
                
            });
            $('#flipbook').on('turning', function(event, page, view) {
                // Lấy tất cả các trang và thêm class 'turning' cho trang đang lật
                $('#flipbook .page').each(function(index) {
                    if (index === page - 1 || index === page) {
                        $(this).addClass('turning'); // Thêm bóng đổ khi trang lật
                    } else {
                        $(this).removeClass('turning-right'); // Xóa bóng đổ khi trang không lật
                    }
                });
            });

            
        });
        function remove_Page(){
            if ($('#flipbook').turn('is')) {
                $('#flipbook').turn('destroy');
            }
            $(flipbook).turn({gradients: true, acceleration: true});
        }
    //    remove.addEventListener("click",()=>{
    //         remove_Page();
            
            //document.getElementById('file-input').value = '';
            //document.getElementById('file-input').textContent = '';
     //  });
        //alert($("#flipbook").lenght);
        // Event listener for PDF file selection
        fileInput.addEventListener("change", (event) => {
            renderedPages = 0;
            var flipbook = document.getElementById("flipbook");
            //$('#flipbook').turn();
            const file = event.target.files[0];
            if (file && file.type === "application/pdf") {
                showLoader();
                convertPdfToFlipbook(file);
                
            } else {
                alert("Please select a valid PDF file.");
            }
            
                //$("#flipbook").turn('update');
            //             alert("Them");
        });
        
        // Convert the selected PDF file into a flipbook
        async function convertPdfToFlipbook(file) {
            const reader = new FileReader();
            reader.onload = async function(e) {
                const pdfData = new Uint8Array(e.target.result);
               
                   
                // Load PDF using PDF.js
                const pdf = await pdfjsLib.getDocument(pdfData).promise;
                const numPages = pdf.numPages;
                flipbook.innerHTML = '';  // Clear any previous content
                // Loop through all pages of the PDF
                for (let pageNum = 1; pageNum <= pdf.numPages; pageNum++) {
                    await renderPage(pdf, pageNum);
                };
                //checkRenderComplete(pdf);
            };
            
            reader.readAsArrayBuffer(file);
            
        }
       
        // Render each page of the PDF as an image
          async function renderPage(pdf, pageNum) {
                const page = await pdf.getPage(pageNum);
                const scale = 1;  // Adjust the scale to zoom in/out the pages
                viewport =  page.getViewport({ scale: scale });

                const canvas =  document.createElement('canvas');
                const context =  canvas.getContext('2d',{ willReadFrequently: true });
                canvas.height =  viewport.height;
                canvas.width =  viewport.width;
                aspectRatio_cavas = canvas.width /  canvas.height;
                // Render the page into the canvas
                // Reder
                
                    await page.render({
                        canvasContext: context,
                        viewport: viewport,
                    }).promise.then( function() {
                        // After rendering, create an image from the canvas
                        const img = new Image();
                        img.src =  canvas.toDataURL();  // Get image data from canvas
                        canvas.remove();
                        // Create a div for each page and add the image
                        const pageDiv =  document.createElement('div');
                        pageDiv.classList.add('page');
                        img.classList.add('zoomable');
                        pageDiv.appendChild(img);
                        flipbook.appendChild(pageDiv);
                        //alert(page)
                        canvas.remove();
                        renderedPages++; // Trang đã render thành công
                        checkRenderComplete(pdf,pageDiv);
                        
                    });
        }
        function checkRenderComplete(pdf,pageDiv) {
                        //alert(renderedPages);
                            if(renderedPages == 1){
                                if ($('#flipbook').turn('is')) {
                                    
                                    $('#flipbook_zoom').on('destroying')
                                    $('#flipbook').turn('destroy').remove;
                                }
                                $(flipbook).turn({gradients: true, acceleration: true,
                                    autoCenter: true  ,
                                    turned: function(event, page, view) {
                                        // Vô hiệu hóa các điều khiển (controls) của trang hiện tại
                                        disableControls(page);
                                    
                                        // Di chuyển trang lật đến vị trí trung tâm
                                        $(this).turn('center');
                                    
                                        // Cập nhật giá trị của thanh trượt (#slider) dựa trên số trang hiện tại
                                        $('#slider').slider('value', getViewNumber($(this), page));
                                    
                                        // Nếu là trang đầu tiên (page == 1), áp dụng hiệu ứng peel (lột) ở góc dưới bên phải
                                        if (page == 1) {
                                            $(this).turn('peel', 'br');
                                        }
                                    }
                                    
                                });
                            }else{
                                    $(flipbook).turn('addPage',pageDiv)
                                    $(flipbook).turn('update');
                            }
                            resize_flipbook();
                            //alert(renderedPages + "," + pdf.numPages)
                            if(renderedPages == 8 && pdf.numPages >= 8){ 
                                hideLoader();
                            }else if (pdf.numPages < 10){
                                //alert("Load xong");
                                hideLoader();
                            }
                            if(renderedPages == pdf.numPages){
                                fileInput.disabled = false;
                                // Zoom
                                $('#flipbook_zoom').zoom({
                                    touch: false,
                                    flipbook: $('#flipbook'),
                                    
                                    // max: function() { 
                                    //     // alert($('#flipbook').width());
                                    //     // alert(largeMagazineWidth());
                                    //     return largeMagazineWidth()/$('#flipbook').width();
                            
                                    // }, 
                                    when: {
                                        swipeLeft: function() {
                            
                                            $(this).zoom('flipbook').turn('next');
                            
                                        },
                            
                                        swipeRight: function() {
                                            
                                            $(this).zoom('flipbook').turn('previous');
                            
                                        },
                            
                                        resize: function(event, scale, page, pageElement) {
                            
                                            if (scale==1)
                                                loadSmallPage(page, pageElement);
                                            else
                                                loadLargePage(page, pageElement);
                                              
                                        },
                                         
                                                 
                                       
                                }
                            });   
                            if ($.isTouch)
                                $('#flipbook_zoom').bind('zoom.doubleTap', zoomTo);
                            else
                                $('#flipbook_zoom').bind('zoom.tap', zoomTo);
                           
                            };
                           //setTimeout( hideLoader(),8000);
        }
        // Đường dẫn cố định (mở xampp để chạy)
        const url = 'PROFILE - SOTA GROUP-đã nén.pdf'; // Đường dẫn tới file PDF
        //const url = 'pccc-cuong-phat-6589.pdf';
        // Khởi tạo PDF.js
         pdfjsLib.getDocument(url).promise.then(function(pdf) {
            const flipbook = document.getElementById('flipbook');
            showLoader();
            LoadUrl(pdf);
            // Lặp qua tất cả các trang của PDF
            
        });
        async function LoadUrl(pdf) {
            for (let pageNum = 1; pageNum <= pdf.numPages; pageNum++) {
                await renderPage(pdf, pageNum);
            }
         }
         
// Zoom
         function largeMagazineWidth() {
	
            return $('#flipbook').width() * 2;
            
        }

    function loadLargePage(page, pageElement) {
	
            var img = $('<img />');
        
            img.on('load', function() {
        
                var prevImg = pageElement.find('img');
                $(this).css({width: '100%', height: '100%'});
                $(this).appendTo(pageElement);
                prevImg.remove();
                
            });
          
            
    }
    function loadSmallPage(page, pageElement) {
	
        var img = pageElement.find('img');
    
        img.css({width: '100%', height: '100%'});
    
        img.unbind('load');
        
    }
    function zoomTo(event) {

        setTimeout(function() {
            if ($('#flipbook_zoom').data().regionClicked) {
                $('#flipbook_zoom').data().regionClicked = false;
            } else {
                if ($('#flipbook_zoom').zoom('value')==1) {
                    $('#flipbook_zoom').zoom('zoomIn', event);
                } else {
                    $('#flipbook_zoom').zoom('zoomOut');
                }
            }
            
        }, 1);
    
    }
    //    let zoomLevel = 1;
    //    $('body').on('wheel', function(event) {
    //     if (event.originalEvent.deltaY < 0) {
    //         // Lăn chuột lên (zoom in)
    //        if(zoomLevel <= 2){
    //         zoomLevel += 0.1;
    //        }
    //     } else if (event.originalEvent.deltaY > 0) {
    //         // Lăn chuột xuống (zoom out)
    //         zoomLevel = Math.max(1, zoomLevel - 0.1);  // Đảm bảo zoom không nhỏ hơn 1
    //        if(zoomLevel === 1){
           
    //        }
    //     }

    //     // Cập nhật kích thước flipbook
    //     $('body').css('transform', `scale(${zoomLevel})`);
        
    // });
    