\ App demo:
include 1991.fs

1991 Constant ENV_PORT

sourcedir s" public" s+ set-public-path
sourcedir s" views/" s+ set-view-path

: handle-/ s" index.html" render-view ;

/1991 / handle-/

\ Views:
: page-title s" EndeyshentLabs v2 ??" ;
: handle-/index
    s" index.html" render-view ;
/1991 /index handle-/index

: start ( -- )
    ENV_PORT 1991:
;
