namespace SereneASP.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('SereneASP');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}