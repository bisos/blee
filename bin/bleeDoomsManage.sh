#!/bin/bash

IimBriefDescription="Manage Multiple Dooms Configurations, Profiles and Setup"

ORIGIN="
* Revision And Libre-Halaal CopyLeft -- Part Of ByStar -- Best Used With Blee
"

####+BEGIN: bx:dblock:bash:top-of-file :vc "cvs" partof: "bystar" :copyleft "halaal+brief"

####+END:

__author__="
* Authors: Mohsen BANAN, http://mohsen.banan.1.byname.net/contact
"


####+BEGIN: bx:bsip:bash:seed-spec :types "seedActions.bash"
SEED="
*  /[dblock]/ /Seed/ :: [[file:/bisos/core/bsip/bin/seedActions.bash]] | 
"
FILE="
*  /This File/ :: /bisos/core/bsip/bin/bxCentralRegistrar.sh 
"
if [ "${loadFiles}" == "" ] ; then
    /bisos/core/bsip/bin/seedActions.bash -l $0 "$@" 
    exit $?
fi
####+END:

_CommentBegin_
####+BEGIN: bx:dblock:global:file-insert-cond :cond "./blee.el" :file "/bisos/apps/defaults/software/plusOrg/dblock/inserts/topControls.org"
*  /Controls/ ::  [[elisp:(org-cycle)][| ]]  [[elisp:(show-all)][Show-All]]  [[elisp:(org-shifttab)][Overview]]  [[elisp:(progn (org-shifttab) (org-content))][Content]] | [[file:Panel.org][Panel]] | [[elisp:(blee:ppmm:org-mode-toggle)][Nat]] | [[elisp:(bx:org:run-me)][Run]] | [[elisp:(bx:org:run-me-eml)][RunEml]] | [[elisp:(delete-other-windows)][(1)]] | [[elisp:(progn (save-buffer) (kill-buffer))][S&Q]]  [[elisp:(save-buffer)][Save]]  [[elisp:(kill-buffer)][Quit]] [[elisp:(org-cycle)][| ]]
** /Version Control/ ::  [[elisp:(call-interactively (quote cvs-update))][cvs-update]]  [[elisp:(vc-update)][vc-update]] | [[elisp:(bx:org:agenda:this-file-otherWin)][Agenda-List]]  [[elisp:(bx:org:todo:this-file-otherWin)][ToDo-List]]
####+END:
_CommentEnd_

_CommentBegin_
*      ================
*  [[elisp:(beginning-of-buffer)][Top]] ################ [[elisp:(delete-other-windows)][(1)]] CONTENTS-LIST ################
*  [[elisp:(org-cycle)][| ]]  Notes         :: *[Current-Info:]*  Status, Notes (Tasks/Todo Lists, etc.) [[elisp:(org-cycle)][| ]]
_CommentEnd_

function vis_moduleDescription {  cat  << _EOF_
*  [[elisp:(org-cycle)][| ]]  Xrefs         :: *[Related/Xrefs:]*  <<Xref-Here->>  -- External Documents  [[elisp:(org-cycle)][| ]]
**  [[elisp:(org-cycle)][| ]]  Panel        :: [[file:/libre/ByStar/InitialTemplates/activeDocs/bxServices/versionControl/fullUsagePanel-en.org::Xref-VersionControl][Panel Roadmap Documentation]] [[elisp:(org-cycle)][| ]]
*  [[elisp:(org-cycle)][| ]]  Info          :: *[Module Description:]* [[elisp:(org-cycle)][| ]]

_EOF_
}

_CommentBegin_
*  [[elisp:(beginning-of-buffer)][Top]] ################ [[elisp:(delete-other-windows)][(1)]]  *Seed Extensions*
_CommentEnd_

_CommentBegin_
*  [[elisp:(org-cycle)][| ]]  Imports       :: Prefaces (Imports/Libraries) [[elisp:(org-cycle)][| ]]
_CommentEnd_

. ${opBinBase}/opAcctLib.sh
. ${opBinBase}/opDoAtAsLib.sh
. ${opBinBase}/lpParams.libSh
. ${opBinBase}/lpReRunAs.libSh

. ${bleeBinBase}/bleeLib.sh

# PRE parameters

profile=""
emacs="0"

function G_postParamHook {
     return 0
}


_CommentBegin_
*  [[elisp:(org-cycle)][| ]]  Examples      :: Examples [[elisp:(org-cycle)][| ]]
_CommentEnd_


function vis_examples {
    typeset extraInfo="-h -v -n showRun"
    #typeset extraInfo=""    
    #typeset extraInfo=""
    typeset runInfo="-p ri=lsipusr:passive"

    typeset examplesInfo="${extraInfo} ${runInfo}"

    profile=doom-blee3
    EH_assert doomProfilePrep

    visLibExamplesOutput ${G_myName} 
  cat  << _EOF_
$( examplesSeperatorTopLabel "${G_myName}" )
$( examplesSeperatorChapter "Blee Lib Examples " )
${G_myName} ${extraInfo} -i examples_bleeLib
${G_myName} ${extraInfo} -i getEmacsVer 0
$(vis_doomProfileAs doom-dist)
$(vis_doomProfileAs doom-withoutBlee3)
$(vis_doomProfileAs doom-blee3)
$( examplesSeperatorChapter "Doom Main Deploy -- profile=doom-dist emacs=sys" )
${G_myName} ${extraInfo} -p emacs=sys -i reBuildAll   # NOTYET, has not been implemented yet
${G_myName} ${extraInfo} -p emacs=29 -i reBuildAll    # NOTYET, has not been implemented yet
$( examplesSeperatorChapter "Doom Main Deploy -- profile=doom-dist emacs=sys" )
${G_myName} ${extraInfo} -p profile=doom-dist -i buildInstall
${G_myName} ${extraInfo} -p profile=doom-dist -i doomSync
${G_myName} ${extraInfo} -p profile=doom-dist -i deleteRunBase
${G_myName} ${extraInfo} -p profile=doom-dist -i reBuild           #  deleteRunBase + buildInstall
$( examplesSeperatorChapter "Doom Main Deploy -- profile=withoutBlee3doom-blee3 emacs=sys" )
${G_myName} ${extraInfo} -p profile=doom-withoutBlee3 -i buildInstall
${G_myName} ${extraInfo} -p profile=doom-withoutBlee3 -i doomSync
${G_myName} ${extraInfo} -p profile=doom-withoutBlee3 -i deleteRunBase
${G_myName} ${extraInfo} -p profile=doom-withoutBlee3 -i reBuild           #  deleteRunBase + buildInstall
$( examplesSeperatorChapter "Switch Config From With to Sans -- profile=doom-blee3 emacs=sys" )
${G_myName} ${extraInfo} -p profile=doom-blee3 -i switchInitTo sansBlee
${G_myName} ${extraInfo} -p profile=doom-blee3 -i switchInitTo withBlee
ls -l /bisos/blee/doom-blee-base/init.el
$( examplesSeperatorChapter "Doom Main Deploy -- profile=doom-blee3 emacs=sys" )
pushd  /bisos/git/anon/ext/emacs/doomemacs ; git pull ; popd
${G_myName} ${extraInfo} -p profile=doom-blee3 -i buildInstall
${G_myName} ${extraInfo} -p profile=doom-blee3 -i doomSync
${G_myName} ${extraInfo} -p profile=doom-blee3 -i deleteRunBase
${G_myName} ${extraInfo} -p profile=doom-blee3 -i reBuild           #  deleteRunBase + buildInstall
ls -ld ${doomRunBase}     # Where straight packages are installed (based on ${doomDirBase})
ls -ld ${doomDirBase}     # Where Doom  init.el, packages.el and config.el are
emacs --debug-init --with-profile doom-blee3 &
blee -i run doom-blee3
$( examplesSeperatorChapter "Doom Main Deploy -- profile=doom-blee3 emacs=29" )
${G_myName} ${extraInfo} -p emacs=29 -p profile=doom-blee3 -i buildInstall
${G_myName} ${extraInfo} -p emacs=29 -p profile=doom-blee3 -i doomSync
${G_myName} ${extraInfo} -p emacs=29 -p profile=doom-blee3 -i deleteRunBase
${G_myName} ${extraInfo} -p emacs=29 -p profile=doom-blee3 -i reBuild           #  deleteRunBase + buildInstall
$( examplesSeperatorChapter "Doom Framework Clones -- one per emacs major version" )
${G_myName} ${extraInfo} -p emacs=28 -i doomFrameworkPrep   # frozen at Dec-2023 pin
${G_myName} ${extraInfo} -p emacs=31 -i doomFrameworkPrep   # tracks latest
ls -ld /bisos/blee/dooms/doomemacs*                         # per-version clones + legacy shared
$( examplesSeperatorChapter "Doom Main Deploy -- profile=doom-blee3 emacs=31" )
${G_myName} ${extraInfo} -p emacs=31 -i doomFrameworkPrep   # run this FIRST, once
${G_myName} ${extraInfo} -p emacs=31 -p profile=doom-blee3 -i buildInstall
${G_myName} ${extraInfo} -p emacs=31 -p profile=doom-blee3 -i doomSync
${G_myName} ${extraInfo} -p emacs=31 -p profile=doom-blee3 -i deleteRunBase
${G_myName} ${extraInfo} -p emacs=31 -p profile=doom-blee3 -i reBuild           #  deleteRunBase + buildInstall
blee -p emacs=31 -i run doom-blee3
$( examplesSeperatorChapter "Blee" )
blee
_EOF_
}

function vis_doomProfileAs {
    EH_assert [[ $# -eq 1 ]]
    profile=$1
    EH_assert doomProfilePrep

  cat  << _EOF_
$( examplesSeperatorSection "profile=${profile}" )
# doomRunBase=${doomRunBase} -- Where straight packages are installed (based on doomDirBase)
# doomDirBase=${doomDirBase}     # Where Doom  init.el, packages.el and config.el are
# doomFrameworkBase=${doomFrameworkBase}
_EOF_
}





noArgsHook() {
  vis_examples
}

_CommentBegin_
*  [[elisp:(org-cycle)][| ]]  IIFs          :: Interactively Invokable Functions (IIF)s |  [[elisp:(org-cycle)][| ]]
_CommentEnd_

_CommentBegin_
*  [[elisp:(org-cycle)][| ]] [[elisp:(org-show-subtree)][|=]] [[elisp:(show-children 10)][|V]] [[elisp:(blee:ppmm:org-mode-toggle)][|N]] [[elisp:(bx:orgm:indirectBufOther)][|>]] [[elisp:(bx:orgm:indirectBufMain)][|I]] [[elisp:(beginning-of-buffer)][|^]] [[elisp:(org-top-overview)][|O]] [[elisp:(progn (org-shifttab) (org-content))][|C]] [[elisp:(delete-other-windows)][|1]] || IIC       ::  buildInstall    [[elisp:(org-cycle)][| ]]
_CommentEnd_



function vis_reBuild {
   G_funcEntry
    function describeF {  G_funcEntryShow; cat  << _EOF_
_EOF_
    }
    EH_assert [[ $# -eq 0 ]]

    lpDo vis_deleteRunBase
    lpDo vis_buildInstall

    lpReturn
}

function vis_deleteRunBase {
   G_funcEntry
    function describeF {  G_funcEntryShow; cat  << _EOF_
_EOF_
    }
    EH_assert [[ $# -eq 0 ]]

    EH_assert doomProfilePrep

    lpDo rm -r -f ${doomRunBase}

    lpReturn
}

function vis_switchInitTo {
   G_funcEntry
    function describeF {  G_funcEntryShow; cat  << _EOF_
** This is temporary.
_EOF_
    }
    EH_assert [[ $# -eq 1 ]]

    EH_assert doomProfilePrep

    local switchTo="$1"

    case ${switchTo} in
        sansBlee)
            case $profile in
                doom-blee3)
                    ANT_raw "switchInitTo -- switchTo=${switchTo} profile=${profile}"
                    lpDo cp ${doomDirBase}/configSansBlee.el ${doomDirBase}/config.el
                    lpDo ls -l  ${doomDirBase}/config.el
                    # lpDo chmod 444 ${doomDirBase}/config.el
                    ;;
                *)
                    EH_problem "Unknown profile=${profile} -- sansBlee skipped"
                    ;;
            esac
            ;;
        withBlee)
            case $profile in
                doom-blee3)
                    ANT_raw "switchInitTo -- switchTo=${switchTo} profile=${profile}"
                    lpDo eval cat ${doomDirBase}/configSansBlee.el ${doomDirBase}/extras.el \>  ${doomDirBase}/configWithBlee.el
                    lpDo cp ${doomDirBase}/configWithBlee.el ${doomDirBase}/config.el
                    lpDo ls -l  ${doomDirBase}/config.el
                    # lpDo chmod 444 ${doomDirBase}/config.el
                    ;;
                *)
                    EH_problem "Unknown profile=${profile} -- withBlee skipped"
                    ;;
            esac
            ;;
        *)
            EH_problem "Bad Input: switchTo=${switchTo}"
            ;;
    esac
}

_CommentBegin_
*  [[elisp:(org-cycle)][| ]] [[elisp:(org-show-subtree)][|=]] [[elisp:(show-children 10)][|V]] [[elisp:(blee:ppmm:org-mode-toggle)][|N]] [[elisp:(bx:orgm:indirectBufOther)][|>]] [[elisp:(bx:orgm:indirectBufMain)][|I]] [[elisp:(beginning-of-buffer)][|^]] [[elisp:(org-top-overview)][|O]] [[elisp:(progn (org-shifttab) (org-content))][|C]] [[elisp:(delete-other-windows)][|1]] || IIC       ::  doomFrameworkPrep    [[elisp:(org-cycle)][| ]]
_CommentEnd_

# doomPinForEmacsMajor and doomPinDescribe now live in bleeLib.sh, next to vis_getEmacsExec /
# vis_getEmacsVer / doomProfilePrep --- see <<doomPinTable>> there. bleeLib.sh is sourced above,
# so both are available here. Keeping one source of truth for the pins.

function vis_doomFrameworkPrep {
   G_funcEntry
    function describeF {  G_funcEntryShow; cat  << _EOF_
** Create or update the per-emacs-major-version doom framework clone.
Each emacs major version gets its own doomemacs working tree, so that emacs28 can stay
frozen at its Dec-2023 pin while emacs31 tracks latest, without the two disturbing
each other. Before this existed there was ONE shared clone that each build reset in place.

Upstream clones live under /bisos/git/anon/ext/emacs/ (the convention for external
upstreams) and are surfaced as symlinks under /bisos/blee/dooms/ (the convention for
blee-visible bases).

Run this ONCE per emacs version before the first buildInstall for that version:
  ${G_myName} -p emacs=31 -i doomFrameworkPrep
Re-running updates a "latest" pin and re-asserts a frozen one.
_EOF_
                       }
    EH_assert [[ $# -eq 0 ]]

    local emacsExec=$( vis_getEmacsExec ${emacs} )

    if [ -z "${emacsExec}" ] ; then
        EH_problem "Bad emacsExec -- is /usr/local/bin/emacs-${emacs} installed?"
        lpReturn 1
    fi

    local emacsVerFull=$( vis_getEmacsVerFromExec ${emacsExec} )
    local emacsMajor=$( echo ${emacsVerFull} | cut -d '.' -f 1 )

    if [ -z "${emacsMajor}" ] ; then
        EH_problem "Could not determine emacs major version from ${emacsExec}"
        lpReturn 1
    fi

    local doomPin=$( doomPinForEmacsMajor ${emacsMajor} )
    local cloneBase="/bisos/git/anon/ext/emacs/doomemacs-${emacsMajor}"
    local linkBase="/bisos/blee/dooms/doomemacs-${emacsMajor}"

    ANT_raw "emacs=${emacsExec} emacsVer=${emacsVerFull}"
    ANT_raw "$( doomPinDescribe ${emacsMajor} )"

    if [ "${doomPin}" == "latest" ] ; then
        ANT_raw "NOTE: emacsMajor=${emacsMajor} has no entry in doomPinTable (bleeLib.sh)."
        ANT_raw "      This is BRING-UP mode. Once this emacs version is proven to build and"
        ANT_raw "      run, pin the commit reported below by adding an entry to doomPinTable."
    fi

    if [ ! -d "${cloneBase}" ] ; then
        lpDo git clone https://github.com/doomemacs/doomemacs.git ${cloneBase}
    fi

    if [ ! -d "${cloneBase}" ] ; then
        EH_problem "Clone failed -- missing ${cloneBase}"
        lpReturn 1
    fi

    if [ "${doomPin}" == "latest" ] ; then
        inBaseDirDo ${cloneBase} git checkout master
        inBaseDirDo ${cloneBase} git pull
    else
        inBaseDirDo ${cloneBase} git fetch --all
        inBaseDirDo ${cloneBase} git reset --hard ${doomPin}
    fi

    lpDo FN_fileSymlinkUpdate ${cloneBase} ${linkBase}

    # NOTE: do NOT pass a quoted --format through inBaseDirDo -- it word-splits its args and
    # the format string shatters. Capture with git -C instead.
    local doomHead=$( git -C ${cloneBase} log -1 --format='%h %ci' )
    ANT_raw "doomFrameworkBase now at: ${doomHead}"

    lpDo ls -ld ${linkBase}

    lpReturn
}


function vis_buildInstall {
   G_funcEntry
    function describeF {  G_funcEntryShow; cat  << _EOF_
_EOF_
    }
    EH_assert [[ $# -eq 0 ]]

    EH_assert doomProfilePrep

    local emacsExec=$(vis_getEmacsExec ${emacs})

    if [ -z "${emacsExec}" ] ; then
        EH_problem "Bad emacsExec=${emacsExec}"
        lpReturn 1
    fi

    # NOTE <2026-09-06>: this used to run a bare "emacs --version", i.e. the SYS emacs, not the
    # emacs selected by -p emacs=NN. On a node whose sys emacs is 28.x, "-p emacs=31 -i reBuild"
    # therefore took the emacs28 branch. It also grep'ed for the digits anywhere in the version
    # line, so 31.0.28 would match 28. Both are fixed by deriving the major from ${emacsExec}.
    local emacsVerFull=$( vis_getEmacsVerFromExec ${emacsExec} )
    local emacsMajor=$( echo ${emacsVerFull} | cut -d '.' -f 1 )

    if [ -z "${emacsMajor}" ] ; then
        EH_problem "Could not determine emacs major version from ${emacsExec}"
        lpReturn 1
    fi

    export DOOMDIR="${doomDirBase}"
    export YES=y
    export EMACS="${emacsExec}"

    lpDo vis_switchInitTo sansBlee

    lpDo mkdir -p ${doomRunBase}

    # NOTE <2026-09-06>: this was "cp -r ${doomFrameworkBase}/* " plus an explicit copy of .git.
    # The glob * does not match DOTFILES, which is why .git needed its own line in 2025. Doom
    # has since added .doom (the version file that doom-version reads), and with the old copy
    # it was silently omitted -- "doom install" then died with:
    #   file-missing ... "<doomRunBase>/.doom"
    # Using "/." copies the directory contents INCLUDING dotfiles, so .doom, .doomrc,
    # .dir-locals.el, .git and anything doom adds next all come across without special cases.
    lpDo cp -r ${doomFrameworkBase}/. ${doomRunBase}

    lpDo echo DOOMDIR=${DOOMDIR}
    lpDo echo EMACS=${EMACS}

    # /bisos/git/anon/ext/emacs/doomemacs /bisos/blee/dooms/doomemacs  --- is anon cloned from https://github.com/doomemacs/doomemacs
    # ln -s /bisos/git/anon/ext/emacs/doomemacs /bisos/blee/dooms/doomemacs
    #

    # <2026-09-06> Doom framework pinning moved OUT of this function.
    #
    # It used to "git reset --hard" the SINGLE shared clone at /bisos/git/anon/ext/emacs/doomemacs.
    # That had two defects: (a) one shared mutable tree cannot support emacs28-pinned and
    # emacs31-latest coexisting --- last builder won; and (b) the reset ran AFTER the "cp -r
    # ${doomFrameworkBase}" above, so the pin only affected the NEXT build, not this one.
    #
    # doomFrameworkBase is now per emacs major version and already carries the correct pin by
    # the time we get here. See doomProfilePrep in bleeLib.sh and -i doomFrameworkPrep below.
    lpDo echo "emacsMajor=${emacsMajor} doomFrameworkBase=${doomFrameworkBase}"

    # If this proved to be a fix, NOTYET, make bystar a param
    lpDo echo "Be Patient, this can take a Long Time -- Running: sudo -u bystar ${doomRunBase}/bin/doom --force install"
    #sudo -u bystar stdbuf -i0 -o0 -e0  ${doomRunBase}/bin/doom --force install  </dev/null
    lpDo eval stdbuf -i0 -o0 -e0  ${doomRunBase}/bin/doom --force install  \</dev/null

    lpDo vis_switchInitTo withBlee

    # NOTYET -- No Longer needed
    # echo "NOTYET, BAD and UGLY"
    # lpDo echo cp /bisos/blee/env3/doom/doom-straight.el /bisos/blee/emacsVers/28.2/doom-run-blee3/lisp/doom-straight.el

    lpReturn
}

function vis_doomSync {
   G_funcEntry
    function describeF {  G_funcEntryShow; cat  << _EOF_
_EOF_
    }
    EH_assert [[ $# -eq 0 ]]

    EH_assert doomProfilePrep

    local emacsExec=$(vis_getEmacsExec ${emacs})

    if [ -z "${emacsExec}" ] ; then
        EH_problem "Bad emacsExec=${emacsExec}"
        lpReturn 1
    fi

    export DOOMDIR="${doomDirBase}"
    export EMACS="${emacsExec}"

    lpDo vis_switchInitTo sansBlee

    lpDo ${doomRunBase}/bin/doom sync

    lpDo vis_switchInitTo withBlee

    lpReturn
}       




_CommentBegin_
*  [[elisp:(beginning-of-buffer)][Top]] ################ [[elisp:(delete-other-windows)][(1)]]  *End Of Editable Text*
_CommentEnd_

####+BEGIN: bx:dblock:bash:end-of-file :type "basic"
_CommentBegin_
*  [[elisp:(org-cycle)][| ]]  Common        ::  /[dblock] -- End-Of-File Controls/ [[elisp:(org-cycle)][| ]]
_CommentEnd_
#+STARTUP: showall
#local variables:
#major-mode: sh-mode
#fill-column: 90
# end:
####+END:
