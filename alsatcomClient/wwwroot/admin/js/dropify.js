(function($) {
  'use strict';
    $('.dropify').dropify({
        messages: {
            'default': 'Bir dosyayı buraya sürükleyip bırakın veya tıklayın',
            'replace': 'Değiştirmek için sürükleyip bırakın veya tıklayın',
            'remove': 'Kaldır',
            'error': 'Hay aksi, yanlış bir şey oldu.'
        },
        error: {
            'fileSize': 'Dosya boyutu çok büyük (maksimum {{ value }}).',
            'minWidth': 'Görüntü genişliği çok küçük (minimum {{ value }}}px).',
            'maxWidth': 'Görüntü genişliği çok büyük (maksimum {{ value }}}px).',
            'minHeight': 'Görüntü yüksekliği çok küçük (minimum {{ value }}}px).',
            'maxHeight': 'Görüntü yüksekliği çok büyük (maksimum {{ value }}}px).',
            'imageFormat': 'Resim biçimine izin verilmiyor. (yalnızca {{ value }}).'
        }
    });
})(jQuery);