import { TestBed } from '@angular/core/testing';

import { ServiceGlobalDemoService } from './service-global-demo.service';

describe('ServiceGlobalDemoService', () => {
  let service: ServiceGlobalDemoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServiceGlobalDemoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
