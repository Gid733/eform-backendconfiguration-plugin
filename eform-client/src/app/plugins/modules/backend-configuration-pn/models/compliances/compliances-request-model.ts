import { PagedEntityRequest } from 'src/app/common/models';

export class CompliancesRequestModel extends PagedEntityRequest {
  propertyId: number;
  constructor() {
    super();
  }
}
