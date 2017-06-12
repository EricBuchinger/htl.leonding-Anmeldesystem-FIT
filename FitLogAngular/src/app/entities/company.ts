export class Company {
        private id: number;
        private name: string;
        private shortDescription: string;
        private address: any;
        private fK_Address: number;
        private fK_Contact: number;
        private contact: any;
        private phoneNumber: string;
        private email: string;
        private homepage: string;
        companySign: string;
        private subjectAreas: string;
        private tag: string;

        constructor(
                id: number,
                name: string,
                shortDescription: string,
                address: string,
                fK_Address: number,
                contact: any,
                fK_Contact: number,
                phoneNumber: string,
                email: string,
                homepage: string,
                companySign: string,
                subjectAreas: string,
                tag: string
        ) {
                this.id = id;
                this.name = name;
                this.shortDescription = shortDescription;
                this.address = address;
                this.fK_Address = fK_Address;
                this.contact = contact;
                this.fK_Contact = fK_Contact;
                this.phoneNumber = phoneNumber;
                this.email = email;
                this.homepage = homepage;
                this.companySign = companySign;
                this.subjectAreas = subjectAreas;
                this.tag = tag;
        }
}
