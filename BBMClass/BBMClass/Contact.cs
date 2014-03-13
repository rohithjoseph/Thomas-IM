/***
 * This is an autogenerated file. DO NOT EDIT THIS FILE OR YOUR CHANGES WILL BE OVERWRITTEN! 
 * If you wish to make changes here, please update the documentation in the bbm_doc git 
 * repository and then rerun the updateschema.py2 script. 
 */

using System;
//using com.bbm.bbmds.internal.JsonConstructable;
using com.bbm.util.Existence;

namespace com.bbm.bbmds{
/// <summary>
/// <p>
/// This is used to store the contact list. Elements are added by core in response to 
/// contactInvitationAccept messages and are removed in response to contactRemove messages 
/// When a contact is added or removed, core notifies the UI via a listAdd or listRemove message 
/// respectively. 
/// </p>
/// </summary>
public class Contact : JsonConstructable {
    /// <summary>
    /// Holds the unique identifier for the user. See uriformats.txt for information on the URI format.
    /// </summary>
    public string uri = "";
    
    /// <summary>
    /// Determines whether this element exists in the user list. If state is Existence.YES, this struct contains real data. Otherwise, all other attributes contain default placeholder data. If the state is Existence.NO, then we know for certain that this
    /// entity does not exist in the daemon. If the state is Existence.MAYBE, then we have not yet confirmed whether this entity exists in the daemon -- normally this is because the client has sent out a request to the daemon that it has not yet answered.
    /// </summary>
    public Existence exists = Existence.MAYBE;
    
    
    /// <summary>
    /// Creates a new instance with default values
    /// </summary>
    public Contact () {}
    
    /// <summary>
    /// Creates a shallow copy of the argument.
    /// </summary>
    /// <param name="toCopy">the object to copy</param>
    public Contact (Contact toCopy) {
        uri = toCopy.uri;
        exists = toCopy.exists;
    }
    
    
    public override string getPrimaryKey() {
        return uri;
    }
    
    
    public override void setAttributes(JSONObject json) {
    
        uri = json.optString("uri", uri);
    }
    
    
    public override JsonConstructable shallowCopy() {
        return new Contact(this);
    }
    
    public override void setExists(Existence exists) {
        this.exists = exists;
    }
    
    public override Existence getExists() {
        return exists;
    }
    
    
    public override int hashCode() {
    
        int prime = 31;
        int result = 1;
        result = prime * result + ((uri == null) ? 0 : uri.hashCode());
        result = prime * result + ((exists == null) ? 0 : exists.hashCode());
        return result;
    }
    
    
    public override bool equals(Object obj) {
    
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        Contact other = (Contact) obj;
        if (uri == null) {
            if (other.uri != null) {
                return false;
            }
        } else if (!uri.equals(other.uri)) {
            return false;
        }
        
        if (!exists.equals(other.exists)) {
            return false;
        }
        
        return true;
    }
}
}