export default {
  reseller: state => ({
    contactPerson: state.reseller.contactPerson,
    contactPhone: state.reseller.contactPhone,
    email: state.reseller.email,
  }),
  company: state => ({
    name: state.company.name,
    address1: state.company.address1,
    city: state.company.city,
    country: state.company.country,
    state: state.company.stateCode,
    postalCode: state.company.postalCode,
    stateCode: state.company.stateCode,
    countryCode: state.company.countryCode,
  }),
  cscpUrl: state => state.cscpUrl,
  cscpDetailsForConfiguration: state => ({
    cscpUrl: state.cscpUrl,
    name: state.company.name,
    address1: state.company.address1,
    city: state.company.city,
    state: state.company.stateCode,
    postalCode: state.company.postalCode,
    country: state.company.country,
    contactPerson: state.reseller.contactPerson,
    contactPhone: state.reseller.contactPhone,
    email: state.reseller.email,
  }),
  createCscpUrlDetails: state => ({
    id: state.company.id,
    customSecureControlPanelURL: state.cscpUrl,
    companyName: state.company.name,
    email: state.reseller.email,
    companyAddressStreet: state.company.address1,
    companyAddressCity: state.company.city,
    companyAddressState: state.company.stateCode,
    companyAddressZipCode: state.company.postalCode,
    companyAddressCountry: state.company.country,
    contactPerson: state.reseller.contactPerson,
    contactPhone: state.reseller.contactPhone,
  }),
};
