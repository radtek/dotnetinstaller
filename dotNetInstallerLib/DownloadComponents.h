#pragma once
#include "DownloadComponent.h"
#include "ThreadComponent.h"

class DownloadComponents : public std::vector<DownloadComponentPtr>, public ThreadComponent
{
private:
	IDownloadCallback * callback;
protected:
	UINT ExecOnThread();
public:
	bool IsCopyRequired() const;
	bool IsDownloadRequired() const;
	DownloadComponents(
		IDownloadCallback * callback, 
		const std::vector<DownloadComponentInfoPtr>& component_info);
};
