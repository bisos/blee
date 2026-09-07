#!/bin/bash # -*- mode: sh-mode; -*-

IcmBriefDescription="NOTYET: Short Description Of The Module"

ORIGIN="
* Revision And Libre-Halaal CopyLeft -- Part Of ByStar -- Best Used With Blee
"

####+BEGIN: bx:bash:top-of-file :vc "cvs" partof: "bystar" :copyleft "halaal+brief"

####+END:

__author__="
* Authors: Mohsen BANAN, http://mohsen.banan.1.byname.net/contact
"

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

# G_emacsServerPid=$(vis_emacsServerPidFromEnv ${G_emacsServerPid})

function vis_examples_bleeLib {
    typeset extraInfo="-h -v -n showRun"
    #typeset extraInfo=""
    typeset runInfo="-p ri=lsipusr:passive"

    local thisEmacsClient=$( vis_thisEmacsClient )
    local emacsServerSocket=$(vis_emacsServerSocketFromEnv)
    local emacsServerVersion=$(vis_emacsServerSocketEmacsVersion ${emacsServerSocket})
    local emacsCmndLine=$(cat /proc/${G_emacsServerPid}/cmdline | xargs -0 echo | cut -f 1 -d " ")

    typeset examplesInfo="${extraInfo} ${runInfo}"

  cat  << _EOF_
$( examplesSeperatorChapter "Blee Lib Feature Examples" )
$( examplesSeperatorSection "Locating The Server" )
${G_myName} ${extraInfo} -i thisEmacsClient                                            # Obatin qualified emacsclient for this Bash
${G_myName} ${extraInfo} -i emacsServerSocketDefault                                   # Obatin the default emacsclient name
${G_myName} ${extraInfo} -i emacsclientProgOfEmacsServerVersion ${emacsServerVersion}  # Obtain emacsclient based on EmacsVersion
${G_myName} ${extraInfo} -i emacsServerSocketBleeVersion ${emacsServerSocket}          # Obtain BleeVersion in Bash
${G_myName} ${extraInfo} -i emacsServerSocketEmacsVersion ${emacsServerSocket}         # Obtain EmacsVersion in Bash
${G_myName} ${extraInfo} -i emacsServerSocketFromEnv                                   # Obtain ServerSocket from environement
${G_myName} ${extraInfo} -i emacsServerPidFromEnv                                      # Obatin ServerPid from environment
$( examplesSeperatorSection "Matching emacs-server and  emacsclient" )
cat /proc/\${G_emacsServerPid}/cmdline | xargs -0 echo | cut -f 1 -d " "
${emacsCmndLine} --version | head -1 | cut -f 3 -d " "
emacsclient --version | cut -f 2 -d " "
${G_myName} ${extraInfo} -i emacsClientMatching
${G_myName} ${extraInfo} -i emacsClientMatchingSet
$( examplesSeperatorSection "Emacs Version Locating" )
${G_myName} ${extraInfo} -i getEmacsVer 0
${G_myName} ${extraInfo} -i getEmacsVer 27
${G_myName} ${extraInfo} -i getEmacsExec 0
${G_myName} ${extraInfo} -i getEmacsExec 27
$( examplesSeperatorSection "Raw emacsclient Invocations" )
$( vis_thisEmacsClient ) --eval "(emacs-version)"
$( vis_examples_bleeLibLine )
_EOF_
}

function vis_examples_bleeLibLine {
    typeset extraInfo="-h -v -n showRun"
    #typeset extraInfo=""
    typeset runInfo="-p ri=lsipusr:passive"

    typeset examplesInfo="${extraInfo} ${runInfo}"

  cat  << _EOF_
${G_myName} ${extraInfo} -i examples_bleeLib        # Blee Lib Feature Examples
_EOF_
}


function vis_defaultEmacsClient {
    function describeF {  cat  << _EOF_

_EOF_
  }
    EH_assert [[ $# -eq 0 ]]

    local emacsServerSocket=$(vis_emacsServerSocketDefault)
    if [ -z "${emacsServerSocket}" ] ; then
        EH_problem "Missing emacsServerSocket"
    fi
    
    local emacsServerVersion=$(vis_emacsServerSocketEmacsVersion ${emacsServerSocket})
    local emacsClientProg=$(vis_emacsclientProgOfEmacsServerVersion ${emacsServerVersion})

    echo "${emacsClientProg} --socket-name=${emacsServerSocket}"
}


function vis_thisEmacsClient {
    function describeF {  cat  << _EOF_

_EOF_
  }
    EH_assert [[ $# -eq 0 ]]

    local emacsServerSocket=$(vis_emacsServerSocketFromEnv)
    if [ -z "${emacsServerSocket}" ] ; then
        EH_problem "Missing emacsServerSocket"
    fi
    
    local emacsServerVersion=$(vis_emacsServerSocketEmacsVersion ${emacsServerSocket})
    local emacsClientProg=$(vis_emacsclientProgOfEmacsServerVersion ${emacsServerVersion})

    echo "${emacsClientProg} --socket-name=${emacsServerSocket}"
}

function vis_emacsclientProgOfEmacsServerVersion {
    function describeF {  cat  << _EOF_
_EOF_
  }
    EH_assert [[ $# -eq 1 ]]

    local emacsVersion="$1"  # UNUSED
    local emacsClient="$(vis_emacsClientMatching)"

    echo "${emacsClient}"
}



function vis_emacsclientProgOfEmacsServerVersion%%Defunct {
    function describeF {  cat  << _EOF_
Given EmacsVersion determine path to emacsclient
** TODO do this based on blee-version and INSIDE_EMACS variable
   SCHEDULED: <2020-02-23 Sun>
_EOF_
  }
    EH_assert [[ $# -eq 1 ]]

    local emacsVersion="$1"
    local emacsClient="$(which emacsclient)"

    #
    # NOTYET, do this based on blee-version and INSIDE_EMACS variable
    #
    case ${emacsVersion} in
        27.0.5 )
            emacsClient="/usr/local/bin/emacsclient27"
            ;;
        *)
            emacsClient="$(which emacsclient)"
            ;;
    esac

    echo "${emacsClient}"
}


function vis_emacsServerSocketBleeVersion {
    function describeF {  cat  << _EOF_
Given emacsServerSocket determine BleeVersion
_EOF_
  }
    EH_assert [[ $# -eq 1 ]]

    local serverSocket="$1"
    
    echo $( basename "${serverSocket}" | cut -d '-' -f 2 ) 
}


function vis_emacsServerSocketEmacsVersion {
    function describeF {  cat  << _EOF_
Given emacsServerSocket determine EmacsVersion
_EOF_
  }
    EH_assert [[ $# -eq 1 ]]

    local serverSocket="$1"
    
    echo $( basename "${serverSocket}" | cut -d '-' -f 3 ) 
}

function vis_emacsServerSocketDefault {
    function describeF {  cat  << _EOF_
The most recent file in /run/user/$(id -u)/emacs is considered default and is returned.
Falls back to /tmp/emacs$(id -u)/ when /run/user/<uid>/emacs/ is absent (e.g. in containers
without systemd-logind where XDG_RUNTIME_DIR is not set).
_EOF_
  }
    EH_assert [[ $# -eq 0 ]]

    local serverSocket=$( ls -t -1 /run/user/$(id -u)/emacs/* 2>/dev/null | head -1 )

    if [ -z "${serverSocket}" ] ; then
        serverSocket=$( ls -t -1 /tmp/emacs$(id -u)/* 2>/dev/null | head -1 )
    fi

    if [ -z "${serverSocket}" ] ; then
        EH_problem "No blee emacs sockets were found"
    fi
    
    echo ${serverSocket}
}


function vis_emacsServerSocketFromEnv {
    function describeF {  cat  << _EOF_
Based on the vis_emacsServerPidFromEnv, find the emacs (server) pid and its socket file.
If no socket file, then look for server and return that.
If no server, then return blank.
_EOF_
  }
    EH_assert [[ $# -eq 0 ]]

    local parentEmacsPid=$( vis_emacsServerPidFromEnv )
    local serverSocket=$( ls -1 /run/user/$(id -u)/emacs/*${parentEmacsPid}* 2> /dev/null )

    if [ -z "${serverSocket}" ] ; then
        serverSocket=$( ls -1 /tmp/emacs$(id -u)/*${parentEmacsPid}* 2> /dev/null )
    fi

    if [ -z "${serverSocket}" ] ; then
        serverSocket=$( ls -1 /run/user/$(id -u)/emacs/server 2> /dev/null )
        if [ -z "${serverSocket}" ] ; then
            serverSocket=$( ls -1 /tmp/emacs$(id -u)/server 2> /dev/null )
        fi
    fi
    
    echo ${serverSocket}
}

function vis_emacsServerPidFromEnv {
    function describeF {  cat  << _EOF_
Determine Emacs Server PID based on environment variable.
_EOF_
  }
    EH_assert [[ $# -eq 0 ]]

    if [ -z "${G_emacsServerPid}" ] ; then
        EH_problem "Missing G_emacsServerPid"
        lpReturn
    fi

    echo ${G_emacsServerPid} 
}


function vis_emacsServerPidFromIcmHeritage {
    function describeF {  cat  << _EOF_
Obsoleted by: vis_emacsServerPidFromEnv
Returns on stdout the parent of the parent of the parent of current process.
This is expected to have been invoked from a shell within emacs as an icm.
The current process is the icmSeed.
The parent of the current process is this running file.
The parent of the parent of the current process is the running shell in emacs.
The parent of the parent of the parent of the current process is the running server emacs.
_EOF_
  }
    EH_assert [[ $# -eq 0 ]]

    echo $( ps ho ppid $(ps ho ppid $(ps ho ppid $$ ) ))
}


function vis_emacsClientMatching {
    function describeF {  cat  << _EOF_
Based on emacsServer set emacsclient to point to the same version.
_EOF_
  }
    EH_assert [[ $# -eq 0 ]]

    local gEmacsServerPid=$(echo ${G_emacsServerPid})  # get rid of spaces in the var

    local emacsCmndLine=$(cat /proc/${G_emacsServerPid}/cmdline | xargs -0 echo | cut -f 1 -d " ")
    local emacsCmndLineVersion=$(${emacsCmndLine} --version | head -1 | cut -f 3 -d " ")
    local emacsCmndLinePath=$(which ${emacsCmndLine})
    local emacsCmndLineEndPath=$(readlink -f ${emacsCmndLinePath})
    local emacsClientMatching=$(echo ${emacsCmndLineEndPath} | sed -e 's/emacs-\(..\).*/emacsclient-\1/')

    if [ ! -e "${emacsClientMatching}" ] ; then
        # On Deb 12, with sys emacs we get /usr/bin/emacsclient-gt, so we get rid of -gt
         emacsClientMatching=$(echo ${emacsCmndLineEndPath} | sed -e 's/emacs-\(..\).*/emacsclient/')
    fi

    echo ${emacsClientMatching}
}


function vis_emacsClientMatchingSet {
    G_funcEntry
    function describeF {  cat  << _EOF_
Based on emacsServer set emacsclient to point to the same version.
_EOF_
  }
    EH_assert [[ $# -eq 0 ]]

    local emacsClientMatching=$(vis_emacsClientMatching)

    if [ ! -f "${emacsClientMatching}" ] ; then
        EH_problem "Missing ${emacsClientMatching}"
        return 101
    fi

    lpDo vis_emacsClientMatchingSetSudo ${emacsClientMatching}
}


function vis_emacsClientMatchingSetSudo {
    G_funcEntry
    function describeF {  cat  << _EOF_
Based on emacsServer set emacsclient to point to the same version.
_EOF_
  }
    EH_assert [[ $# -eq 1 ]]
    local emacsClientMatching="$1"

    if vis_reRunAsRoot ${G_thisFunc} $@ ; then lpReturn ${globalReRunRetVal}; fi;    
    lpDo FN_fileSymlinkRemoveIfThere /usr/local/bin/emacsclient
    lpDo FN_fileSymlinkUpdate ${emacsClientMatching} /usr/local/bin/emacsclient
}


function vis_getEmacsExec {
   G_funcEntry
   function describeF {  G_funcEntryShow; cat  << _EOF_
** Given an emacs version (28, 28.1 29.0.50), find the corresponding exec in /usr/local.
For example ${funcName} 28, produces /usr/local/bin/emacs-28.
When 0, default emacs executable. Likely /usr/local/bin/emacs.
_EOF_
    }
    EH_assert [[ $# -eq 1 ]]

    local emacsVer="$1"
    local result=""

    case $emacsVer in
        "0")
	    if [ -f "/usr/local/bin/emacs-28" ] ; then
		result="/usr/local/bin/emacs-28"
	    else
		result=$(which emacs)
	    fi
            ;;
        "sys")
	    result=$(which emacs)
            ;;
	*)
            result="/usr/local/bin/emacs-${emacsVer}"
            if [ ! -e "${result}" ] ; then
		EH_problem "Bad input: ${emacsVer} -- Missing ${result}"
                result=""
	    fi
            ;;
    esac

    echo ${result}
    
    lpReturn
}

function vis_getEmacsVerFromExec {
   G_funcEntry
   function describeF {  G_funcEntryShow; cat  << _EOF_
** Given an emacs executable, get the full emacs version.
_EOF_
    }
    EH_assert [[ $# -eq 1 ]]

    local result=""
    local emacsCmnd="$1"

    if [ -e "${emacsCmnd}" ] ; then
	result=$(${emacsCmnd} --version | head -1 | cut -f 3 -d " ")
    else
	EH_problem "Bad Input: ${emacsCmnd} -- Missing ${emacsCmnd}"
        result=""
    fi

    echo ${result}
    
    lpReturn
}

function vis_getEmacsVer {
   G_funcEntry
    function describeF {  G_funcEntryShow; cat  << _EOF_
_EOF_
    }
    EH_assert [[ $# -eq 1 ]]

    local emacsVer="$1"
    local emacsExec=$(vis_getEmacsExec  ${emacsVer})    
    local result=""

    if [ -z "${emacsExec}" ] ; then
	EH_problem "Bad Result from vis_getEmacsExec"
	result=""
    else
	result=$(vis_getEmacsVerFromExec "${emacsExec}")
	if [ -z "${result}" ] ; then
	    EH_problem "Bad Result from is_getEmacsVerFromExec"
	    result=""
	fi
    fi
    echo ${result}
    lpReturn
}

####+BEGIN: NOTYET --- doomPinTable
#
# <<doomPinTable>>  --- Which doom commit each emacs major version is built against.
#
# WHY A TABLE AT ALL:
#   Doom pins its OWN package versions (169 packages, 121 explicit pins as of 01d68aaf6).
#   So the package set is a pure function of the doom commit. The doom commit is therefore
#   the single lever controlling what blee actually is. Pin it and the whole tree is
#   reproducible; leave it floating and all 169 packages move at once, silently.
#
# WHY KEYED ON THE DERIVED VERSION, NOT THE SELECTOR:
#   emacs=sys / emacs=0 / emacs=28 / emacs=31 are SELECTORS, not versions, and what "sys"
#   means differs per node. vis_getEmacsVerFromExec asks the binary itself, so every
#   selector funnels through one honest question. Never key a pin on the selector.
#   (Observed 2026-09-06: on this node emacs=sys -> 28.2 while emacs=28 FAILS, because the
#   28.2 here is /bin/emacs and /usr/local/bin/emacs-28 does not exist.)
#
# THE WORKFLOW THIS ENCODES:
#   Bring a new emacs version up on "latest", prove it builds and runs, THEN pin the commit
#   it was proven with. "latest" is bring-up mode, not a steady state. Anything left on
#   "latest" is by definition not yet proven.
#
# GRANULARITY: keyed on emacs MAJOR version. 31.1.50 and a future 31.4 share a pin, so each
#   entry records which exact emacs version it was actually tested against --- that keeps the
#   drift visible even though the key is coarse.
#
# TO MOVE A PIN: re-run bleeDoomsManage.sh -p emacs=<N> -i doomFrameworkPrep, rebuild, RUN it,
#   then update the entry here including its testedAgainst/testedOn provenance.
#
####+END:

function doomPinForEmacsMajor {
    local emacsMajor="$1"

    case ${emacsMajor} in
        28)
            # testedAgainst: emacs 28.x   testedOn: <2023-12-08>  status: FROZEN
            # sha1 obtained Fri Dec 8 12:13:10 2023 from a stable release -- git rev-parse HEAD
            # Do not move this without re-testing blee on emacs28.
            echo "03d692f129633e3bf0bd100d91b3ebf3f77db6d1"
            ;;
        31)
            # testedAgainst: emacs 31.1.50   testedOn: <2026-09-06 Sun>   status: PROVEN
            # doom 01d68aaf6 (2026-09-05 "docs: add warning about doomemacs.com").
            # Evidence: doomFrameworkPrep + reBuild of profile doom-blee3 completed clean in
            # 5m22s, 169 straight packages, "Doom successfully installed!", and blee-31 then
            # ran well enough to drive magit and commit. Pinned on that evidence.
            echo "01d68aaf6bd7db073365385cd82e1ad7e815295c"
            ;;
        *)
            # No entry yet == not yet proven on this emacs version. Bring it up on latest,
            # then add an entry above with its provenance.
            echo "latest"
            ;;
    esac
}

function doomPinDescribe {
    local emacsMajor="$1"
    local doomPin=$( doomPinForEmacsMajor ${emacsMajor} )

    if [ "${doomPin}" == "latest" ] ; then
        echo "emacsMajor=${emacsMajor} doomPin=latest (UNPINNED -- tracking upstream master, not yet proven)"
    else
        echo "emacsMajor=${emacsMajor} doomPin=${doomPin}"
    fi
}

function doomProfilePrep {
   G_funcEntry
   function describeF {  G_funcEntryShow; cat  << _EOF_
\${profile} name here need not match what is blee's .emacs-profile.el, but we use the same.
But
** Three variables are set:
1) <<doomFrameworkBase>> /bisos/blee/dooms/doomemacs-<emacsMajor> --- anon clone of https://github.com/doomemacs/doomemacs
   PER EMACS MAJOR VERSION, so that a build for one emacs can never disturb the doom tree
   another emacs is pinned to. emacs28 stays on its Dec-2023 pin while emacs31 tracks latest.
   Falls back to the historical shared /bisos/blee/dooms/doomemacs when no per-version clone
   exists, so emacs 28/29/30 behave exactly as before this change.
   Create/update with: bleeDoomsManage.sh -p emacs=<N> -i doomFrameworkPrep
2) <<doomDirBase>> /bisos/blee/dooms/doom-base-blee3  == Equivalent of .doom.d dir for packages and config
3) <<doomRunBase>> /bisos/blee/emacsVers/<emacsVer>/doom-run-blee3  == Re-creatable by bleeDoomsManage.sh
_EOF_
    }
    EH_assert [[ $# -eq 0 ]]

    if [ -z "${profile}" ] ; then
        lpReturn 1
    fi
    local emacsVer=$(vis_getEmacsVer ${emacs})

    if [ -z "${emacsVer}" ] ; then
        EH_problem "Bad emacsVer=${emacsVer}"
        lpReturn 1
    fi

    #doomFrameworkBase=/bisos/blee/doom-emacs-framework
    #
    # doomFrameworkBase is PER EMACS MAJOR VERSION. Before 2026-09 there was a single shared
    # doomemacs clone and bleeDoomsManage.sh git-reset it in place per build, which could not
    # support two emacs versions coexisting. Each major version now gets its own clone at its
    # own pin. Create them with: bleeDoomsManage.sh -p emacs=<N> -i doomFrameworkPrep
    #
    # The fallback keeps this backwards compatible: until a per-version clone is created, the
    # historical shared clone is used, so emacs 28/29/30 are unaffected by this change.
    local emacsMajor=$( echo ${emacsVer} | cut -d '.' -f 1 )
    doomFrameworkBase="/bisos/blee/dooms/doomemacs-${emacsMajor}"
    if [ ! -d "${doomFrameworkBase}" ] ; then
        doomFrameworkBase="/bisos/blee/dooms/doomemacs"
    fi
    case $profile in
        doom-dist)
            #doomRunBase="/bisos/blee/emacsVers/${emacsVer}/doom-main-emacs"
            doomRunBase="/bisos/blee/emacsVers/${emacsVer}/doom-run-emacs"
            # instead of doom-base-emacs it should have be called doom-base-dist
            doomDirBase="/bisos/blee/dooms/doom-base-emacs"
            ;;

        doom-withoutBlee3)
            doomRunBase="/bisos/blee/emacsVers/${emacsVer}/doom-run-withoutBlee3"
            doomDirBase="/bisos/blee/dooms/doom-base-blee3/doom-base-withoutBlee3"
            ;;

        doom-blee3)
            doomRunBase="/bisos/blee/emacsVers/${emacsVer}/doom-run-blee3"
            doomDirBase="/bisos/blee/dooms/doom-base-blee3"
            ;;

        *)
            EH_problem "Unknown profile=$profile"
            lpReturn 1
            ;;
    esac

    lpReturn
}


########## JUNKYARD  ############


function doomProfilePrepOld {
   G_funcEntry
   function describeF {  G_funcEntryShow; cat  << _EOF_
USED By oldBlee --- Delete when deleteing oldBlee
\${profile} name here need not match what is blee's .emacs-profile.el, but we use the same.
But
** Three variables are set:
1) <<doomFrameworkBase>> /bisos/blee/dooms/doomemacs  --- is anon cloned from https://github.com/doomemacs/doomemacs
2) <<doomDirBase>> /bisos/blee/dooms/doom-base-blee3  == Equivalent of .doom.d dir for packages and config
3) <<doomRunBase>> /bisos/blee/emacsVers/28.1/doom-main-blee3  == Re-creatable by bleeDoomManage.sh
_EOF_
    }
    EH_assert [[ $# -eq 0 ]]

    if [ -z "${profile}" ] ; then
        lpReturn 1
    fi
    local emacsVer=$(vis_getEmacsVer ${emacs})

    if [ -z "${emacsVer}" ] ; then
        EH_problem "Bad emacsVer=${emacsVer}"
        lpReturn 1
    fi

    #doomFrameworkBase=/bisos/blee/doom-emacs-framework
    doomFrameworkBase="/bisos/blee/dooms/doomemacs"
    case $profile in
        doom-dist)
            #doomRunBase="/bisos/blee/emacsVers/${emacsVer}/doom-main-emacs"
            doomRunBase="/bisos/blee/emacsVers/${emacsVer}/doom-main-emacs"
            # instead of doom-base-emacs it should have be called doom-base-dist
            doomDirBase="/bisos/blee/dooms/doom-base-emacs"
            ;;

        doom-withoutBlee3)
            doomRunBase="/bisos/blee/emacsVers/${emacsVer}/doom-main-withoutBlee3"
            doomDirBase="/bisos/blee/dooms/doom-base-blee3/doom-base-withoutBlee3"
            ;;

        doom-blee3)
            doomRunBase="/bisos/blee/emacsVers/${emacsVer}/doom-main-blee3"
            doomDirBase="/bisos/blee/dooms/doom-base-blee3"
            ;;

        *)
            EH_problem "Unknown profile=$profile"
            lpReturn 1
            ;;
    esac

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
