
import {Person} from "./person.model";
import {EntityObject} from "./entityObject";
export interface Contact extends EntityObject{
  person:Person;
}
